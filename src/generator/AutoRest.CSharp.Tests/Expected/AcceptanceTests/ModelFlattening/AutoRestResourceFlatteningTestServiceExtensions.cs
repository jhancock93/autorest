// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsModelFlattening
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AutoRestResourceFlatteningTestService.
    /// </summary>
    public static partial class AutoRestResourceFlatteningTestServiceExtensions
    {
            /// <summary>
            /// Put External Resource as an Array
            /// <see href="http://tempuri.org" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceArray'>
            /// External Resource as an Array to put
            /// </param>
            public static void PutArray(this IAutoRestResourceFlatteningTestService operations, IList<Resource> resourceArray = default(IList<Resource>))
            {
                operations.PutArrayAsync(resourceArray).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put External Resource as an Array
            /// <see href="http://tempuri.org" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceArray'>
            /// External Resource as an Array to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutArrayAsync(this IAutoRestResourceFlatteningTestService operations, IList<Resource> resourceArray = default(IList<Resource>), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutArrayWithHttpMessagesAsync(resourceArray, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get External Resource as an Array
            /// <see href="http://tempuri.org" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<FlattenedProduct> GetArray(this IAutoRestResourceFlatteningTestService operations)
            {
                return operations.GetArrayAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get External Resource as an Array
            /// <see href="http://tempuri.org" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<FlattenedProduct>> GetArrayAsync(this IAutoRestResourceFlatteningTestService operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetArrayWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// No need to have a route in Express server for this operation. Used to
            /// verify the type flattened is not removed if it's referenced in an array
            /// <see href="http://tempuri.org" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceArray'>
            /// External Resource as an Array to put
            /// </param>
            public static void PutWrappedArray(this IAutoRestResourceFlatteningTestService operations, IList<WrappedProduct> resourceArray = default(IList<WrappedProduct>))
            {
                operations.PutWrappedArrayAsync(resourceArray).GetAwaiter().GetResult();
            }

            /// <summary>
            /// No need to have a route in Express server for this operation. Used to
            /// verify the type flattened is not removed if it's referenced in an array
            /// <see href="http://tempuri.org" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceArray'>
            /// External Resource as an Array to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutWrappedArrayAsync(this IAutoRestResourceFlatteningTestService operations, IList<WrappedProduct> resourceArray = default(IList<WrappedProduct>), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutWrappedArrayWithHttpMessagesAsync(resourceArray, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// No need to have a route in Express server for this operation. Used to
            /// verify the type flattened is not removed if it's referenced in an array
            /// <see href="http://tempuri.org" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<ProductWrapper> GetWrappedArray(this IAutoRestResourceFlatteningTestService operations)
            {
                return operations.GetWrappedArrayAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// No need to have a route in Express server for this operation. Used to
            /// verify the type flattened is not removed if it's referenced in an array
            /// <see href="http://tempuri.org" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ProductWrapper>> GetWrappedArrayAsync(this IAutoRestResourceFlatteningTestService operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWrappedArrayWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put External Resource as a Dictionary
            /// <see href="http://tempuri.org" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceDictionary'>
            /// External Resource as a Dictionary to put
            /// </param>
            public static void PutDictionary(this IAutoRestResourceFlatteningTestService operations, IDictionary<string, FlattenedProduct> resourceDictionary = default(IDictionary<string, FlattenedProduct>))
            {
                operations.PutDictionaryAsync(resourceDictionary).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put External Resource as a Dictionary
            /// <see href="http://tempuri.org" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceDictionary'>
            /// External Resource as a Dictionary to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutDictionaryAsync(this IAutoRestResourceFlatteningTestService operations, IDictionary<string, FlattenedProduct> resourceDictionary = default(IDictionary<string, FlattenedProduct>), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutDictionaryWithHttpMessagesAsync(resourceDictionary, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get External Resource as a Dictionary
            /// <see href="http://tempuri.org" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IDictionary<string, FlattenedProduct> GetDictionary(this IAutoRestResourceFlatteningTestService operations)
            {
                return operations.GetDictionaryAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get External Resource as a Dictionary
            /// <see href="http://tempuri.org" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IDictionary<string, FlattenedProduct>> GetDictionaryAsync(this IAutoRestResourceFlatteningTestService operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDictionaryWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put External Resource as a ResourceCollection
            /// <see href="http://tempuri.org" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceComplexObject'>
            /// External Resource as a ResourceCollection to put
            /// </param>
            public static void PutResourceCollection(this IAutoRestResourceFlatteningTestService operations, ResourceCollection resourceComplexObject = default(ResourceCollection))
            {
                operations.PutResourceCollectionAsync(resourceComplexObject).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put External Resource as a ResourceCollection
            /// <see href="http://tempuri.org" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceComplexObject'>
            /// External Resource as a ResourceCollection to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutResourceCollectionAsync(this IAutoRestResourceFlatteningTestService operations, ResourceCollection resourceComplexObject = default(ResourceCollection), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutResourceCollectionWithHttpMessagesAsync(resourceComplexObject, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get External Resource as a ResourceCollection
            /// <see href="http://tempuri.org" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static ResourceCollection GetResourceCollection(this IAutoRestResourceFlatteningTestService operations)
            {
                return operations.GetResourceCollectionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get External Resource as a ResourceCollection
            /// <see href="http://tempuri.org" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceCollection> GetResourceCollectionAsync(this IAutoRestResourceFlatteningTestService operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetResourceCollectionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put Simple Product with client flattening true on the model
            /// <see href="http://tempuri.org" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='simpleBodyProduct'>
            /// Simple body product to put
            /// </param>
            public static SimpleProduct PutSimpleProduct(this IAutoRestResourceFlatteningTestService operations, SimpleProduct simpleBodyProduct = default(SimpleProduct))
            {
                return operations.PutSimpleProductAsync(simpleBodyProduct).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put Simple Product with client flattening true on the model
            /// <see href="http://tempuri.org" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='simpleBodyProduct'>
            /// Simple body product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SimpleProduct> PutSimpleProductAsync(this IAutoRestResourceFlatteningTestService operations, SimpleProduct simpleBodyProduct = default(SimpleProduct), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutSimpleProductWithHttpMessagesAsync(simpleBodyProduct, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put Flattened Simple Product with client flattening true on the parameter
            /// <see href="http://tempuri.org" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='productId'>
            /// Unique identifier representing a specific product for a given latitude
            /// &amp; longitude. For example, uberX in San Francisco will have a different
            /// product_id than uberX in Los Angeles.
            /// </param>
            /// <param name='maxProductDisplayName'>
            /// Display name of product.
            /// </param>
            /// <param name='description'>
            /// Description of product.
            /// </param>
            /// <param name='genericValue'>
            /// Generic URL value.
            /// </param>
            /// <param name='odatavalue'>
            /// URL value.
            /// </param>
            public static SimpleProduct PostFlattenedSimpleProduct(this IAutoRestResourceFlatteningTestService operations, string productId, string maxProductDisplayName, string description = default(string), string genericValue = default(string), string odatavalue = default(string))
            {
                return operations.PostFlattenedSimpleProductAsync(productId, maxProductDisplayName, description, genericValue, odatavalue).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put Flattened Simple Product with client flattening true on the parameter
            /// <see href="http://tempuri.org" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='productId'>
            /// Unique identifier representing a specific product for a given latitude
            /// &amp; longitude. For example, uberX in San Francisco will have a different
            /// product_id than uberX in Los Angeles.
            /// </param>
            /// <param name='maxProductDisplayName'>
            /// Display name of product.
            /// </param>
            /// <param name='description'>
            /// Description of product.
            /// </param>
            /// <param name='genericValue'>
            /// Generic URL value.
            /// </param>
            /// <param name='odatavalue'>
            /// URL value.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SimpleProduct> PostFlattenedSimpleProductAsync(this IAutoRestResourceFlatteningTestService operations, string productId, string maxProductDisplayName, string description = default(string), string genericValue = default(string), string odatavalue = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostFlattenedSimpleProductWithHttpMessagesAsync(productId, maxProductDisplayName, description, genericValue, odatavalue, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put Simple Product with client flattening true on the model
            /// <see href="http://tempuri.org" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='flattenParameterGroup'>
            /// Additional parameters for the operation
            /// </param>
            public static SimpleProduct PutSimpleProductWithGrouping(this IAutoRestResourceFlatteningTestService operations, FlattenParameterGroup flattenParameterGroup)
            {
                return operations.PutSimpleProductWithGroupingAsync(flattenParameterGroup).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put Simple Product with client flattening true on the model
            /// <see href="http://tempuri.org" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='flattenParameterGroup'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SimpleProduct> PutSimpleProductWithGroupingAsync(this IAutoRestResourceFlatteningTestService operations, FlattenParameterGroup flattenParameterGroup, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutSimpleProductWithGroupingWithHttpMessagesAsync(flattenParameterGroup, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
