using MultiRPC.Core.Rpc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;

namespace MultiRPC.Core.Page
{
    public interface IRpcPage : INotifyPropertyChanged
    {
        /// <summary>
        /// The rich presence made from the contents of this page
        /// </summary>
        RichPresence RichPresence { get; }

        /// <summary>
        /// Gets when this page is being accessed
        /// </summary>
        event EventHandler Accessed;

        /// <summary>
        /// The localizable name of this page 
        /// </summary>
        public string LocalizableName { get; }

        /// <summary>
        /// If the rich presence is vaild for use for a RPC Client
        /// </summary>
        public bool VaildRichPresence { get; }
    }
}
