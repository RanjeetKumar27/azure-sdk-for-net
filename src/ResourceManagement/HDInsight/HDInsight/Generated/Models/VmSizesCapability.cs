// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;

namespace Microsoft.Azure.Management.HDInsight.Models
{
    public partial class VmSizesCapability
    {
        private IList<string> _availableVmSizes;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<string> AvailableVmSizes
        {
            get { return this._availableVmSizes; }
            set { this._availableVmSizes = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VmSizesCapability class.
        /// </summary>
        public VmSizesCapability()
        {
            this.AvailableVmSizes = new LazyList<string>();
        }
    }
}
