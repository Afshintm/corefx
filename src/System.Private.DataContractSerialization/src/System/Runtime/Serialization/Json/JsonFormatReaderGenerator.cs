// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Xml;

#if NET_NATIVE
namespace System.Runtime.Serialization.Json
{
    public delegate object JsonFormatClassReaderDelegate(XmlReaderDelegator xmlReader, XmlObjectSerializerReadContextComplexJson context, XmlDictionaryString emptyDictionaryString, XmlDictionaryString[] memberNames);
    public delegate object JsonFormatCollectionReaderDelegate(XmlReaderDelegator xmlReader, XmlObjectSerializerReadContextComplexJson context, XmlDictionaryString emptyDictionaryString, XmlDictionaryString itemName, CollectionDataContract collectionContract);
    public delegate void JsonFormatGetOnlyCollectionReaderDelegate(XmlReaderDelegator xmlReader, XmlObjectSerializerReadContextComplexJson context, XmlDictionaryString emptyDictionaryString, XmlDictionaryString itemName, CollectionDataContract collectionContract);
}
#endif
