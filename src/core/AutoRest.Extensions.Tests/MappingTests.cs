﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.IO;
using AutoRest.Core;
using AutoRest.Core.Utilities;
using AutoRest.CSharp;
using AutoRest.Swagger;
using Xunit;

namespace AutoRest.Extensions.Tests
{
    public class MappingExtensionsTests
    {
        [Fact]
        public void TestInputMapping()
        {
            var settings = new Settings
            {
                Namespace = "Test",
                Input = Path.Combine("Swagger", "swagger-payload-flatten.json"),
                PayloadFlatteningThreshold = 3,
                OutputDirectory = Path.GetTempPath()
            };
            settings.FileSystem = new MemoryFileSystem();
            settings.FileSystem.WriteFile("AutoRest.json", File.ReadAllText("AutoRest.json"));
            settings.FileSystem.CreateDirectory(Path.GetDirectoryName(settings.Input));
            settings.FileSystem.WriteFile(settings.Input, File.ReadAllText(settings.Input));

            var modeler = new SwaggerModeler(settings);
            var clientModel = modeler.Build();
            CSharpCodeGenerator generator = new CSharpCodeGenerator(settings);
            generator.NormalizeClientModel(clientModel);
            generator.Generate(clientModel).GetAwaiter().GetResult();
            string body = settings.FileSystem.ReadFileAsText(Path.Combine(settings.OutputDirectory, "Payload.cs"));
            Assert.True(body.ContainsMultiline(@"
                MinProduct minProduct = new MinProduct();
                if (baseProductId != null || baseProductDescription != null || maxProductReference != null)
                {
                    minProduct.BaseProductId = baseProductId;
                    minProduct.BaseProductDescription = baseProductDescription;
                    minProduct.MaxProductReference = maxProductReference;
                }"));
        }

        [Fact]
        public void TestCSharpExternalModelReferences()
        {
            var settings = new Settings
            {
                Namespace = "Test",
                Input = Path.Combine("Swagger", "swagger-externalmodels.json"),
                OutputDirectory = "X:"
            };
            settings.FileSystem = new MemoryFileSystem();
            settings.FileSystem.WriteFile("AutoRest.json", File.ReadAllText("AutoRest.json"));
            settings.FileSystem.CreateDirectory(Path.GetDirectoryName(settings.Input));
            settings.FileSystem.WriteFile(settings.Input, File.ReadAllText(settings.Input));

            var modeler = new SwaggerModeler(settings);
            var clientModel = modeler.Build();
            Assert.NotNull(clientModel);

            var generator = new AutoRest.CSharp.CSharpCodeGenerator(settings);
            generator.PopulateSettings(settings.CustomSettings);
            generator.NormalizeClientModel(clientModel);
            Assert.Contains("AutoRest.Tests.ExternalModels", generator.ReferencedNamespaces);
            generator.Generate(clientModel).GetAwaiter().GetResult();

            //Ensure the model was found and that the client references the namespace of the ExternalTestModel
            string clientBody = settings.FileSystem.ReadFileAsText(Path.Combine("X:", "SwaggerExternalModelClient.cs"));
            Assert.Contains("using AutoRest.Tests.ExternalModels", clientBody, StringComparison.Ordinal);
            Assert.Contains("ExternalTestModel", clientBody, StringComparison.Ordinal);
            Assert.True(settings.FileSystem.FileExists(Path.Combine("X:", "Models", "Order.cs")));

            //The generator should NOT have created a model file for ExternalTestModel
            Assert.False(settings.FileSystem.FileExists(Path.Combine("X:", "Models", "ExternalTestModel.cs")));
        }
    }
}
