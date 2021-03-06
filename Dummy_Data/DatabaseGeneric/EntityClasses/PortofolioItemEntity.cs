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
	/// <summary>Entity class which represents the entity 'PortofolioItem'.<br/><br/></summary>
	[Serializable]
	public partial class PortofolioItemEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private PortofolioEntity _portofolio;
		private StockEntity _stock;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static PortofolioItemEntityStaticMetaData _staticMetaData = new PortofolioItemEntityStaticMetaData();
		private static PortofolioItemRelations _relationsFactory = new PortofolioItemRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Portofolio</summary>
			public static readonly string Portofolio = "Portofolio";
			/// <summary>Member name Stock</summary>
			public static readonly string Stock = "Stock";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class PortofolioItemEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public PortofolioItemEntityStaticMetaData()
			{
				SetEntityCoreInfo("PortofolioItemEntity", InheritanceHierarchyType.None, false, (int)Dummy.EntityType.PortofolioItemEntity, typeof(PortofolioItemEntity), typeof(PortofolioItemEntityFactory), false);
				AddNavigatorMetaData<PortofolioItemEntity, PortofolioEntity>("Portofolio", "PortofolioItems", (a, b) => a._portofolio = b, a => a._portofolio, (a, b) => a.Portofolio = b, Dummy.RelationClasses.StaticPortofolioItemRelations.PortofolioEntityUsingPortofolioIdStatic, ()=>new PortofolioItemRelations().PortofolioEntityUsingPortofolioId, null, new int[] { (int)PortofolioItemFieldIndex.PortofolioId }, null, true, (int)Dummy.EntityType.PortofolioEntity);
				AddNavigatorMetaData<PortofolioItemEntity, StockEntity>("Stock", "PortofolioItems", (a, b) => a._stock = b, a => a._stock, (a, b) => a.Stock = b, Dummy.RelationClasses.StaticPortofolioItemRelations.StockEntityUsingStockIdStatic, ()=>new PortofolioItemRelations().StockEntityUsingStockId, null, new int[] { (int)PortofolioItemFieldIndex.StockId }, null, true, (int)Dummy.EntityType.StockEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static PortofolioItemEntity()
		{
		}

		/// <summary> CTor</summary>
		public PortofolioItemEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public PortofolioItemEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this PortofolioItemEntity</param>
		public PortofolioItemEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="portofolioItemId">PK value for PortofolioItem which data should be fetched into this PortofolioItem object</param>
		public PortofolioItemEntity(System.Int64 portofolioItemId) : this(portofolioItemId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="portofolioItemId">PK value for PortofolioItem which data should be fetched into this PortofolioItem object</param>
		/// <param name="validator">The custom validator object for this PortofolioItemEntity</param>
		public PortofolioItemEntity(System.Int64 portofolioItemId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.PortofolioItemId = portofolioItemId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected PortofolioItemEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Portofolio' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPortofolio() { return CreateRelationInfoForNavigator("Portofolio"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Stock' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoStock() { return CreateRelationInfoForNavigator("Stock"); }
		
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
		/// <param name="validator">The validator object for this PortofolioItemEntity</param>
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
		public static PortofolioItemRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Portofolio' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPortofolio { get { return _staticMetaData.GetPrefetchPathElement("Portofolio", CommonEntityBase.CreateEntityCollection<PortofolioEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Stock' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathStock { get { return _staticMetaData.GetPrefetchPathElement("Stock", CommonEntityBase.CreateEntityCollection<StockEntity>()); } }

		/// <summary>The AverageValue property of the Entity PortofolioItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PortofolioItem"."AverageValue".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal AverageValue
		{
			get { return (System.Decimal)GetValue((int)PortofolioItemFieldIndex.AverageValue, true); }
			set	{ SetValue((int)PortofolioItemFieldIndex.AverageValue, value); }
		}

		/// <summary>The CreateDate property of the Entity PortofolioItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PortofolioItem"."CreateDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime2, 7, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime CreateDate
		{
			get { return (System.DateTime)GetValue((int)PortofolioItemFieldIndex.CreateDate, true); }
			set	{ SetValue((int)PortofolioItemFieldIndex.CreateDate, value); }
		}

		/// <summary>The Lot property of the Entity PortofolioItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PortofolioItem"."Lot".<br/>Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int64 Lot
		{
			get { return (System.Int64)GetValue((int)PortofolioItemFieldIndex.Lot, true); }
			set	{ SetValue((int)PortofolioItemFieldIndex.Lot, value); }
		}

		/// <summary>The PortofolioId property of the Entity PortofolioItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PortofolioItem"."PortofolioId".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 PortofolioId
		{
			get { return (System.Int32)GetValue((int)PortofolioItemFieldIndex.PortofolioId, true); }
			set	{ SetValue((int)PortofolioItemFieldIndex.PortofolioId, value); }
		}

		/// <summary>The PortofolioItemId property of the Entity PortofolioItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PortofolioItem"."PortofolioItemId".<br/>Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 PortofolioItemId
		{
			get { return (System.Int64)GetValue((int)PortofolioItemFieldIndex.PortofolioItemId, true); }
			set { SetValue((int)PortofolioItemFieldIndex.PortofolioItemId, value); }		}

		/// <summary>The Shared property of the Entity PortofolioItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PortofolioItem"."Shared".<br/>Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int64 Shared
		{
			get { return (System.Int64)GetValue((int)PortofolioItemFieldIndex.Shared, true); }
			set	{ SetValue((int)PortofolioItemFieldIndex.Shared, value); }
		}

		/// <summary>The StockId property of the Entity PortofolioItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PortofolioItem"."StockId".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 StockId
		{
			get { return (System.Int32)GetValue((int)PortofolioItemFieldIndex.StockId, true); }
			set	{ SetValue((int)PortofolioItemFieldIndex.StockId, value); }
		}

		/// <summary>The TotalValue property of the Entity PortofolioItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PortofolioItem"."TotalValue".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal TotalValue
		{
			get { return (System.Decimal)GetValue((int)PortofolioItemFieldIndex.TotalValue, true); }
			set	{ SetValue((int)PortofolioItemFieldIndex.TotalValue, value); }
		}

		/// <summary>The UpdateDate property of the Entity PortofolioItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PortofolioItem"."UpdateDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime2, 7, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime UpdateDate
		{
			get { return (System.DateTime)GetValue((int)PortofolioItemFieldIndex.UpdateDate, true); }
			set	{ SetValue((int)PortofolioItemFieldIndex.UpdateDate, value); }
		}

		/// <summary>The Version property of the Entity PortofolioItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PortofolioItem"."Version".<br/>Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int64 Version
		{
			get { return (System.Int64)GetValue((int)PortofolioItemFieldIndex.Version, true); }
			set	{ SetValue((int)PortofolioItemFieldIndex.Version, value); }
		}

		/// <summary>Gets / sets related entity of type 'PortofolioEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual PortofolioEntity Portofolio
		{
			get { return _portofolio; }
			set { SetSingleRelatedEntityNavigator(value, "Portofolio"); }
		}

		/// <summary>Gets / sets related entity of type 'StockEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual StockEntity Stock
		{
			get { return _stock; }
			set { SetSingleRelatedEntityNavigator(value, "Stock"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace Dummy
{
	public enum PortofolioItemFieldIndex
	{
		///<summary>AverageValue. </summary>
		AverageValue,
		///<summary>CreateDate. </summary>
		CreateDate,
		///<summary>Lot. </summary>
		Lot,
		///<summary>PortofolioId. </summary>
		PortofolioId,
		///<summary>PortofolioItemId. </summary>
		PortofolioItemId,
		///<summary>Shared. </summary>
		Shared,
		///<summary>StockId. </summary>
		StockId,
		///<summary>TotalValue. </summary>
		TotalValue,
		///<summary>UpdateDate. </summary>
		UpdateDate,
		///<summary>Version. </summary>
		Version,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace Dummy.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: PortofolioItem. </summary>
	public partial class PortofolioItemRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between PortofolioItemEntity and PortofolioEntity over the m:1 relation they have, using the relation between the fields: PortofolioItem.PortofolioId - Portofolio.PortofolioId</summary>
		public virtual IEntityRelation PortofolioEntityUsingPortofolioId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Portofolio", false, new[] { PortofolioFields.PortofolioId, PortofolioItemFields.PortofolioId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between PortofolioItemEntity and StockEntity over the m:1 relation they have, using the relation between the fields: PortofolioItem.StockId - Stock.StockId</summary>
		public virtual IEntityRelation StockEntityUsingStockId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Stock", false, new[] { StockFields.StockId, PortofolioItemFields.StockId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticPortofolioItemRelations
	{
		internal static readonly IEntityRelation PortofolioEntityUsingPortofolioIdStatic = new PortofolioItemRelations().PortofolioEntityUsingPortofolioId;
		internal static readonly IEntityRelation StockEntityUsingStockIdStatic = new PortofolioItemRelations().StockEntityUsingStockId;

		/// <summary>CTor</summary>
		static StaticPortofolioItemRelations() { }
	}
}
