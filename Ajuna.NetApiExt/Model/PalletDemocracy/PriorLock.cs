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


namespace Ajuna.NetApi.Model.PalletDemocracy
{
    
    
    /// <summary>
    /// >> 181 - Composite[pallet_democracy.vote.PriorLock]
    /// </summary>
    public sealed class PriorLock : BaseType
    {
        
        /// <summary>
        /// >> BlockNumber
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _blockNumber;
        
        /// <summary>
        /// >> Balance
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _balance;
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 BlockNumber
        {
            get
            {
                return this._blockNumber;
            }
            set
            {
                this._blockNumber = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 Balance
        {
            get
            {
                return this._balance;
            }
            set
            {
                this._balance = value;
            }
        }
        
        public override string TypeName()
        {
            return "PriorLock";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(BlockNumber.Encode());
            result.AddRange(Balance.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            BlockNumber = new Ajuna.NetApi.Model.Types.Primitive.U32();
            BlockNumber.Decode(byteArray, ref p);
            Balance = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Balance.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
