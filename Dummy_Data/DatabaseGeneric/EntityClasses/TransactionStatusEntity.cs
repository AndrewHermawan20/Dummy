﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Dummy.HelperClasses;
using Dummy.FactoryClasses;
using Dummy.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Dummy.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'TransactionStatus'.<br/><br/></summary>
	[Serializable]
	public partial class TransactionStatusEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<TransactionEntity> _transactions;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static TransactionStatusEntityStaticMetaData _staticMetaData = new TransactionStatusEntityStaticMetaData();
		private static TransactionStatusRelations _relationsFactory = new TransactionStatusRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Transactions</summary>
			public static readonly string Transactions = "Transactions";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class TransactionStatusEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public TransactionStatusEntityStaticMetaData()
			{
				SetEntityCoreInfo("TransactionStatusEntity", InheritanceHierarchyType.None, false, (int)Dummy.EntityType.TransactionStatusEntity, typeof(TransactionStatusEntity), typeof(TransactionStatusEntityFactory), false);
				AddNavigatorMetaData<TransactionStatusEntity, EntityCollection<TransactionEntity>>("Transactions", a => a._transactions, (a, b) => a._transactions = b, a => a.Transactions, () => new TransactionStatusRelations().TransactionEntityUsingTransactionStatusId, typeof(TransactionEntity), (int)Dummy.EntityType.TransactionEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static TransactionStatusEntity()
		{
		}

		/// <summary> CTor</summary>
		public TransactionStatusEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public TransactionStatusEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this TransactionStatusEntity</param>
		public TransactionStatusEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="transactionStatusId">PK value for TransactionStatus which data should be fetched into this TransactionStatus object</param>
		public TransactionStatusEntity(System.Int16 transactionStatusId) : this(transactionStatusId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="transactionStatusId">PK value for TransactionStatus which data should be fetched into this TransactionStatus object</param>
		/// <param name="validator">The custom validator object for this TransactionStatusEntity</param>
		public TransactionStatusEntity(System.Int16 transactionStatusId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.TransactionStatusId = transactionStatusId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected TransactionStatusEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Transaction' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTransactions() { return CreateRelationInfoForNavigator("Transactions"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this TransactionStatusEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static TransactionStatusRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Transaction' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTransactions { get { return _staticMetaData.GetPrefetchPathElement("Transactions", CommonEntityBase.CreateEntityCollection<TransactionEntity>()); } }

		/// <summary>The Code property of the Entity TransactionStatus<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TransactionStatus"."Code".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Code
		{
			get { return (System.String)GetValue((int)TransactionStatusFieldIndex.Code, true); }
			set	{ SetValue((int)TransactionStatusFieldIndex.Code, value); }
		}

		/// <summary>The CreateDate property of the Entity TransactionStatus<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TransactionStatus"."CreateDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime2, 7, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime CreateDate
		{
			get { return (System.DateTime)GetValue((int)TransactionStatusFieldIndex.CreateDate, true); }
			set	{ SetValue((int)TransactionStatusFieldIndex.CreateDate, value); }
		}

		/// <summary>The Name property of the Entity TransactionStatus<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TransactionStatus"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)TransactionStatusFieldIndex.Name, true); }
			set	{ SetValue((int)TransactionStatusFieldIndex.Name, value); }
		}

		/// <summary>The TransactionStatusId property of the Entity TransactionStatus<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TransactionStatus"."TransactionStatusId".<br/>Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int16 TransactionStatusId
		{
			get { return (System.Int16)GetValue((int)TransactionStatusFieldIndex.TransactionStatusId, true); }
			set { SetValue((int)TransactionStatusFieldIndex.TransactionStatusId, value); }		}

		/// <summary>The Version property of the Entity TransactionStatus<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TransactionStatus"."Version".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 Version
		{
			get { return (System.Int32)GetValue((int)TransactionStatusFieldIndex.Version, true); }
			set	{ SetValue((int)TransactionStatusFieldIndex.Version, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'TransactionEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(TransactionEntity))]
		public virtual EntityCollection<TransactionEntity> Transactions { get { return GetOrCreateEntityCollection<TransactionEntity, TransactionEntityFactory>("TransactionStatus", true, false, ref _transactions); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace Dummy
{
	public enum TransactionStatusFieldIndex
	{
		///<summary>Code. </summary>
		Code,
		///<summary>CreateDate. </summary>
		CreateDate,
		///<summary>Name. </summary>
		Name,
		///<summary>TransactionStatusId. </summary>
		TransactionStatusId,
		///<summary>Version. </summary>
		Version,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace Dummy.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: TransactionStatus. </summary>
	public partial class TransactionStatusRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between TransactionStatusEntity and TransactionEntity over the 1:n relation they have, using the relation between the fields: TransactionStatus.TransactionStatusId - Transaction.TransactionStatusId</summary>
		public virtual IEntityRelation TransactionEntityUsingTransactionStatusId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Transactions", true, new[] { TransactionStatusFields.TransactionStatusId, TransactionFields.TransactionStatusId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticTransactionStatusRelations
	{
		internal static readonly IEntityRelation TransactionEntityUsingTransactionStatusIdStatic = new TransactionStatusRelations().TransactionEntityUsingTransactionStatusId;

		/// <summary>CTor</summary>
		static StaticTransactionStatusRelations() { }
	}
}
