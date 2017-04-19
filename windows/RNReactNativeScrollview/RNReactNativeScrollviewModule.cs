using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Com.Reactlibrary.RNReactNativeScrollview
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeScrollviewModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeScrollviewModule"/>.
        /// </summary>
        internal RNReactNativeScrollviewModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeScrollview";
            }
        }
    }
}
