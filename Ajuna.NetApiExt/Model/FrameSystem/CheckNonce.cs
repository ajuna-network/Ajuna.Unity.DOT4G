//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace Ajuna.NetApi.Model.FrameSystem
{
    
    
    /// <summary>
    /// >> 217 - Composite[frame_system.extensions.check_nonce.CheckNonce]
    /// </summary>
    public sealed class CheckNonce : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> _value;
        
        public BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        public override string TypeName()
        {
            return "CheckNonce";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
