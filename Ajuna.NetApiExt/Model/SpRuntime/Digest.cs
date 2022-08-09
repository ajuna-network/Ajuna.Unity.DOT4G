//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.SpRuntime;
using Ajuna.NetApi.Model.Types.Base;
using System;
using System.Collections.Generic;


namespace Ajuna.NetApi.Model.SpRuntime
{
    
    
    /// <summary>
    /// >> 11 - Composite[sp_runtime.generic.digest.Digest]
    /// </summary>
    public sealed class Digest : BaseType
    {
        
        /// <summary>
        /// >> logs
        /// </summary>
        private BaseVec<Ajuna.NetApi.Model.SpRuntime.EnumDigestItem> _logs;
        
        public BaseVec<Ajuna.NetApi.Model.SpRuntime.EnumDigestItem> Logs
        {
            get
            {
                return this._logs;
            }
            set
            {
                this._logs = value;
            }
        }
        
        public override string TypeName()
        {
            return "Digest";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Logs.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Logs = new BaseVec<Ajuna.NetApi.Model.SpRuntime.EnumDigestItem>();
            Logs.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
