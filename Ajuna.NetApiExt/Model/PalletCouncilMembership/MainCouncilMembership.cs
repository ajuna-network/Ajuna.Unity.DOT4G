//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Extrinsics;
using Ajuna.NetApi.Model.Meta;
using Ajuna.NetApi.Model.SpCore;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Ajuna.NetApi.Model.PalletCouncilMembership
{
    
    
    public sealed class CouncilMembershipStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public CouncilMembershipStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CouncilMembership", "Members"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(BaseVec<Ajuna.NetApi.Model.SpCore.AccountId32>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CouncilMembership", "Prime"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.SpCore.AccountId32)));
        }
        
        /// <summary>
        /// >> MembersParams
        ///  The current membership, stored as an ordered Vec.
        /// </summary>
        public static string MembersParams()
        {
            return RequestGenerator.GetStorage("CouncilMembership", "Members", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Members
        ///  The current membership, stored as an ordered Vec.
        /// </summary>
        public async Task<BaseVec<Ajuna.NetApi.Model.SpCore.AccountId32>> Members(CancellationToken token)
        {
            string parameters = CouncilMembershipStorage.MembersParams();
            return await _client.GetStorageAsync<BaseVec<Ajuna.NetApi.Model.SpCore.AccountId32>>(parameters, token);
        }
        
        /// <summary>
        /// >> PrimeParams
        ///  The current prime member, if one exists.
        /// </summary>
        public static string PrimeParams()
        {
            return RequestGenerator.GetStorage("CouncilMembership", "Prime", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Prime
        ///  The current prime member, if one exists.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.SpCore.AccountId32> Prime(CancellationToken token)
        {
            string parameters = CouncilMembershipStorage.PrimeParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.SpCore.AccountId32>(parameters, token);
        }
    }
    
    public sealed class CouncilMembershipCalls
    {
        
        /// <summary>
        /// >> add_member
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method AddMember(Ajuna.NetApi.Model.SpCore.AccountId32 who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(10, "CouncilMembership", 0, "add_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_member
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemoveMember(Ajuna.NetApi.Model.SpCore.AccountId32 who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(10, "CouncilMembership", 1, "remove_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> swap_member
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SwapMember(Ajuna.NetApi.Model.SpCore.AccountId32 remove, Ajuna.NetApi.Model.SpCore.AccountId32 add)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(remove.Encode());
            byteArray.AddRange(add.Encode());
            return new Method(10, "CouncilMembership", 2, "swap_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> reset_members
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ResetMembers(BaseVec<Ajuna.NetApi.Model.SpCore.AccountId32> members)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(members.Encode());
            return new Method(10, "CouncilMembership", 3, "reset_members", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> change_key
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ChangeKey(Ajuna.NetApi.Model.SpCore.AccountId32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(10, "CouncilMembership", 4, "change_key", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_prime
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetPrime(Ajuna.NetApi.Model.SpCore.AccountId32 who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(10, "CouncilMembership", 5, "set_prime", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> clear_prime
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ClearPrime()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(10, "CouncilMembership", 6, "clear_prime", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> MemberAdded
    /// The given member was added; see the transaction for who.
    /// </summary>
    public sealed class EventMemberAdded : BaseTuple
    {
    }
    
    /// <summary>
    /// >> MemberRemoved
    /// The given member was removed; see the transaction for who.
    /// </summary>
    public sealed class EventMemberRemoved : BaseTuple
    {
    }
    
    /// <summary>
    /// >> MembersSwapped
    /// Two members were swapped; see the transaction for who.
    /// </summary>
    public sealed class EventMembersSwapped : BaseTuple
    {
    }
    
    /// <summary>
    /// >> MembersReset
    /// The membership was reset; see the transaction for who the new set is.
    /// </summary>
    public sealed class EventMembersReset : BaseTuple
    {
    }
    
    /// <summary>
    /// >> KeyChanged
    /// One of the members' keys changed.
    /// </summary>
    public sealed class EventKeyChanged : BaseTuple
    {
    }
    
    /// <summary>
    /// >> Dummy
    /// Phantom member, never used.
    /// </summary>
    public sealed class EventDummy : BaseTuple
    {
    }
    
    public enum CouncilMembershipErrors
    {
        
        /// <summary>
        /// >> AlreadyMember
        /// Already a member.
        /// </summary>
        AlreadyMember,
        
        /// <summary>
        /// >> NotMember
        /// Not a member.
        /// </summary>
        NotMember,
    }
}
