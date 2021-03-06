// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
namespace Xenko.Core.Yaml
{
    /// <summary>
    /// Placeholder value to remove keys from <see cref="DynamicYamlMapping"/>.
    /// </summary>
    public class DynamicYamlEmpty : DynamicYamlObject
    {
        public static readonly DynamicYamlEmpty Default = new DynamicYamlEmpty();    
    }
}
