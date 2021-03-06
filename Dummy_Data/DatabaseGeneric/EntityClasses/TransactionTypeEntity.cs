//////////////////////////////////////////////////////////////
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
	/// <summary>Entity class which represents the entity 'TransactionType'.<br/><br/></summary>
	[Serializable]
	public partial class TransactionTypeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<TransactionEntity> _transactions;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static TransactionTypeEntityStaticMetaData _staticMetaData = new TransactionTypeEntityStaticMetaData();
		private static TransactionTypeRelations _relationsFactory = new TransactionTypeRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Transactions</summary>
			public static readonly string Transactions = "Transactions";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class TransactionTypeEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public TransactionTypeEntityStaticMetaData()
			{
				SetEntityCoreInfo("TransactionTypeEntity", InheritanceHierarchyType.None, false, (int)Dummy.EntityType.TransactionTypeEntity, typeof(TransactionTypeEntity), typeof(TransactionTypeEntityFactory), false);
				AddNavigatorMetaData<TransactionTypeEntity, EntityCollection<TransactionEntity>>("Transactions", a => a._transactions, (a, b) => a._transactions = b, a => a.Transactions, () => new TransactionTypeRelations().TransactionEntityUsingTransactionTypeId, typeof(TransactionEntity), (int)Dummy.EntityType.TransactionEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static TransactionTypeEntity()
		{
		}

		/// <summary> CTor</summary>
		public TransactionTypeEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public TransactionTypeEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this TransactionTypeEntity</param>
		public TransactionTypeEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="transactionTypeId">PK value for TransactionType which data should be fetched into this TransactionType object</param>
		public TransactionTypeEntity(System.Int16 transactionTypeId) : this(transactionTypeId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="transactionTypeId">PK value for TransactionType which data should be fetched into this TransactionType object</param>
		/// <param name="validator">The custom validator object for this TransactionTypeEntity</param>
		public TransactionTypeEntity(System.Int16 transactionTypeId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.TransactionTypeId = transactionTypeId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected TransactionTypeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
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
		/// <param name="validator">The validator object for this TransactionTypeEntity</param>
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
		public static TransactionTypeRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Transaction' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTransactions { get { return _staticMetaData.GetPrefetchPathElement("Transactions", CommonEntityBase.CreateEntityCollection<TransactionEntity>()); } }

		/// <summary>The Code property of the Entity TransactionType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TransactionType"."Code".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Code
		{
			get { return (System.String)GetValue((int)TransactionTypeFieldIndex.Code, true); }
			set	{ SetValue((int)TransactionTypeFieldIndex.Code, value); }
		}

		/// <summary>The CreateDate property of the Entity TransactionType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TransactionType"."CreateDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime2, 7, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime CreateDate
		{
			get { return (System.DateTime)GetValue((int)TransactionTypeFieldIndex.CreateDate, true); }
			set	{ SetValue((int)TransactionTypeFieldIndex.CreateDate, value); }
		}

		/// <summary>The Name property of the Entity TransactionType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TransactionType"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)TransactionTypeFieldIndex.Name, true); }
			set	{ SetValue((int)TransactionTypeFieldIndex.Name, value); }
		}

		/// <summary>The TransactionTypeId property of the Entity TransactionType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TransactionType"."TransactionTypeId".<br/>Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int16 TransactionTypeId
		{
			get { return (System.Int16)GetValue((int)TransactionTypeFieldIndex.TransactionTypeId, true); }
			set { SetValue((int)TransactionTypeFieldIndex.TransactionTypeId, value); }		}

		/// <summary>The Version property of the Entity TransactionType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TransactionType"."Version".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 Version
		{
			get { return (System.Int32)GetValue((int)TransactionTypeFieldIndex.Version, true); }
			set	{ SetValue((int)TransactionTypeFieldIndex.Version, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'TransactionEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(TransactionEntity))]
		public virtual EntityCollection<TransactionEntity> Transactions { get { return GetOrCreateEntityCollection<TransactionEntity, TransactionEntityFactory>("TransactionType", true, false, ref _transactions); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace Dummy
{
	public enum TransactionTypeFieldIndex
	{
		///<summary>Code. </summary>
		Code,
		///<summary>CreateDate. </summary>
		CreateDate,
		///<summary>Name. </summary>
		Name,
		///<summary>TransactionTypeId. </summary>
		TransactionTypeId,
		///<summary>Version. </summary>
		Version,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace Dummy.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: TransactionType. </summary>
	public partial class TransactionTypeRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between TransactionTypeEntity and TransactionEntity over the 1:n relation they have, using the relation between the fields: TransactionType.TransactionTypeId - Transaction.TransactionTypeId</summary>
		public virtual IEntityRelation TransactionEntityUsingTransactionTypeId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Transactions", true, new[] { TransactionTypeFields.TransactionTypeId, TransactionFields.TransactionTypeId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticTransactionTypeRelations
	{
		internal static readonly IEntityRelation TransactionEntityUsingTransactionTypeIdStatic = new TransactionTypeRelations().TransactionEntityUsingTransactionTypeId;

		/// <summary>CTor</summary>
		static StaticTransactionTypeRelations() { }
	}
}
