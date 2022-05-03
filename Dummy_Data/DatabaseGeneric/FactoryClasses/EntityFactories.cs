﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using Dummy.EntityClasses;
using Dummy.HelperClasses;
using Dummy.RelationClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Dummy.FactoryClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>general base class for the generated factories</summary>
	[Serializable]
	public partial class EntityFactoryBase2<TEntity> : EntityFactoryCore2
		where TEntity : EntityBase2, IEntity2
	{
		private readonly bool _isInHierarchy;

		/// <summary>CTor</summary>
		/// <param name="entityName">Name of the entity.</param>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <param name="isInHierarchy">If true, the entity of this factory is in an inheritance hierarchy, false otherwise</param>
		public EntityFactoryBase2(string entityName, Dummy.EntityType typeOfEntity, bool isInHierarchy) : base(entityName, (int)typeOfEntity)
		{
			_isInHierarchy = isInHierarchy;
		}
		
		/// <inheritdoc/>
		public override IEntityFields2 CreateFields() { return ModelInfoProviderSingleton.GetInstance().GetEntityFields(this.ForEntityName); }
		
		/// <inheritdoc/>
		public override IEntity2 CreateEntityFromEntityTypeValue(int entityTypeValue) {	return GeneralEntityFactory.Create((Dummy.EntityType)entityTypeValue); }

		/// <inheritdoc/>
		public override IRelationCollection CreateHierarchyRelations(string objectAlias) { return ModelInfoProviderSingleton.GetInstance().GetHierarchyRelations(this.ForEntityName, objectAlias); }

		/// <inheritdoc/>
		public override IEntityFactory2 GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity) 
		{
			return (IEntityFactory2)ModelInfoProviderSingleton.GetInstance().GetEntityFactory(this.ForEntityName, fieldValues, entityFieldStartIndexesPerEntity) ?? this;
		}
		
		/// <inheritdoc/>
		public override IPredicateExpression GetEntityTypeFilter(bool negate, string objectAlias) {	return ModelInfoProviderSingleton.GetInstance().GetEntityTypeFilter(this.ForEntityName, objectAlias, negate);	}
						
		/// <inheritdoc/>
		public override IEntityCollection2 CreateEntityCollection()	{ return new EntityCollection<TEntity>(this); }
		
		/// <inheritdoc/>
		public override IEntityFields2 CreateHierarchyFields() 
		{
			return _isInHierarchy ? new EntityFields2(ModelInfoProviderSingleton.GetInstance().GetHierarchyFields(this.ForEntityName), ModelInfoProviderSingleton.GetInstance(), null) : base.CreateHierarchyFields();
		}
		
		/// <inheritdoc/>
		protected override Type ForEntityType { get { return typeof(TEntity); } }
	}

	/// <summary>Factory to create new, empty ConfigurationEntity objects.</summary>
	[Serializable]
	public partial class ConfigurationEntityFactory : EntityFactoryBase2<ConfigurationEntity> 
	{
		/// <summary>CTor</summary>
		public ConfigurationEntityFactory() : base("ConfigurationEntity", Dummy.EntityType.ConfigurationEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity2 CreateImpl(IEntityFields2 fields) { return new ConfigurationEntity(fields); }
	}

	/// <summary>Factory to create new, empty OrderHistoryEntity objects.</summary>
	[Serializable]
	public partial class OrderHistoryEntityFactory : EntityFactoryBase2<OrderHistoryEntity> 
	{
		/// <summary>CTor</summary>
		public OrderHistoryEntityFactory() : base("OrderHistoryEntity", Dummy.EntityType.OrderHistoryEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity2 CreateImpl(IEntityFields2 fields) { return new OrderHistoryEntity(fields); }
	}

	/// <summary>Factory to create new, empty OrderTypeEntity objects.</summary>
	[Serializable]
	public partial class OrderTypeEntityFactory : EntityFactoryBase2<OrderTypeEntity> 
	{
		/// <summary>CTor</summary>
		public OrderTypeEntityFactory() : base("OrderTypeEntity", Dummy.EntityType.OrderTypeEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity2 CreateImpl(IEntityFields2 fields) { return new OrderTypeEntity(fields); }
	}

	/// <summary>Factory to create new, empty PortofolioEntity objects.</summary>
	[Serializable]
	public partial class PortofolioEntityFactory : EntityFactoryBase2<PortofolioEntity> 
	{
		/// <summary>CTor</summary>
		public PortofolioEntityFactory() : base("PortofolioEntity", Dummy.EntityType.PortofolioEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity2 CreateImpl(IEntityFields2 fields) { return new PortofolioEntity(fields); }
	}

	/// <summary>Factory to create new, empty PortofolioItemEntity objects.</summary>
	[Serializable]
	public partial class PortofolioItemEntityFactory : EntityFactoryBase2<PortofolioItemEntity> 
	{
		/// <summary>CTor</summary>
		public PortofolioItemEntityFactory() : base("PortofolioItemEntity", Dummy.EntityType.PortofolioItemEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity2 CreateImpl(IEntityFields2 fields) { return new PortofolioItemEntity(fields); }
	}

	/// <summary>Factory to create new, empty StockEntity objects.</summary>
	[Serializable]
	public partial class StockEntityFactory : EntityFactoryBase2<StockEntity> 
	{
		/// <summary>CTor</summary>
		public StockEntityFactory() : base("StockEntity", Dummy.EntityType.StockEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity2 CreateImpl(IEntityFields2 fields) { return new StockEntity(fields); }
	}

	/// <summary>Factory to create new, empty StockSectorEntity objects.</summary>
	[Serializable]
	public partial class StockSectorEntityFactory : EntityFactoryBase2<StockSectorEntity> 
	{
		/// <summary>CTor</summary>
		public StockSectorEntityFactory() : base("StockSectorEntity", Dummy.EntityType.StockSectorEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity2 CreateImpl(IEntityFields2 fields) { return new StockSectorEntity(fields); }
	}

	/// <summary>Factory to create new, empty SummaryEntity objects.</summary>
	[Serializable]
	public partial class SummaryEntityFactory : EntityFactoryBase2<SummaryEntity> 
	{
		/// <summary>CTor</summary>
		public SummaryEntityFactory() : base("SummaryEntity", Dummy.EntityType.SummaryEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity2 CreateImpl(IEntityFields2 fields) { return new SummaryEntity(fields); }
	}

	/// <summary>Factory to create new, empty TransactionEntity objects.</summary>
	[Serializable]
	public partial class TransactionEntityFactory : EntityFactoryBase2<TransactionEntity> 
	{
		/// <summary>CTor</summary>
		public TransactionEntityFactory() : base("TransactionEntity", Dummy.EntityType.TransactionEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity2 CreateImpl(IEntityFields2 fields) { return new TransactionEntity(fields); }
	}

	/// <summary>Factory to create new, empty TransactionStatusEntity objects.</summary>
	[Serializable]
	public partial class TransactionStatusEntityFactory : EntityFactoryBase2<TransactionStatusEntity> 
	{
		/// <summary>CTor</summary>
		public TransactionStatusEntityFactory() : base("TransactionStatusEntity", Dummy.EntityType.TransactionStatusEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity2 CreateImpl(IEntityFields2 fields) { return new TransactionStatusEntity(fields); }
	}

	/// <summary>Factory to create new, empty TransactionTypeEntity objects.</summary>
	[Serializable]
	public partial class TransactionTypeEntityFactory : EntityFactoryBase2<TransactionTypeEntity> 
	{
		/// <summary>CTor</summary>
		public TransactionTypeEntityFactory() : base("TransactionTypeEntity", Dummy.EntityType.TransactionTypeEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity2 CreateImpl(IEntityFields2 fields) { return new TransactionTypeEntity(fields); }
	}

	/// <summary>Factory to create new, empty UserEntity objects.</summary>
	[Serializable]
	public partial class UserEntityFactory : EntityFactoryBase2<UserEntity> 
	{
		/// <summary>CTor</summary>
		public UserEntityFactory() : base("UserEntity", Dummy.EntityType.UserEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity2 CreateImpl(IEntityFields2 fields) { return new UserEntity(fields); }
	}

	/// <summary>Factory to create new, empty Entity objects based on the entity type specified. Uses  entity specific factory objects</summary>
	[Serializable]
	public partial class GeneralEntityFactory
	{
		/// <summary>Creates a new, empty Entity object of the type specified</summary>
		/// <param name="entityTypeToCreate">The entity type to create.</param>
		/// <returns>A new, empty Entity object.</returns>
		public static IEntity2 Create(Dummy.EntityType entityTypeToCreate)
		{
			var factoryToUse = EntityFactoryFactory.GetFactory(entityTypeToCreate);
			IEntity2 toReturn = null;
			if(factoryToUse != null)
			{
				toReturn = factoryToUse.Create();
			}
			return toReturn;
		}		
	}
		
	/// <summary>Class which is used to obtain the entity factory based on the .NET type of the entity. </summary>
	[Serializable]
	public static class EntityFactoryFactory
	{
		private static Dictionary<Type, IEntityFactory2> _factoryPerType = new Dictionary<Type, IEntityFactory2>();

		/// <summary>Initializes the <see cref="EntityFactoryFactory"/> class.</summary>
		static EntityFactoryFactory()
		{
			foreach(int entityTypeValue in Enum.GetValues(typeof(Dummy.EntityType)))
			{
				var factory = GetFactory((Dummy.EntityType)entityTypeValue);
				_factoryPerType.Add(factory.ForEntityType ?? factory.Create().GetType(), factory);
			}
		}

		/// <summary>Gets the factory of the entity with the .NET type specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(Type typeOfEntity) { return _factoryPerType.GetValue(typeOfEntity); }

		/// <summary>Gets the factory of the entity with the Dummy.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(Dummy.EntityType typeOfEntity)
		{
			switch(typeOfEntity)
			{
				case Dummy.EntityType.ConfigurationEntity:
					return new ConfigurationEntityFactory();
				case Dummy.EntityType.OrderHistoryEntity:
					return new OrderHistoryEntityFactory();
				case Dummy.EntityType.OrderTypeEntity:
					return new OrderTypeEntityFactory();
				case Dummy.EntityType.PortofolioEntity:
					return new PortofolioEntityFactory();
				case Dummy.EntityType.PortofolioItemEntity:
					return new PortofolioItemEntityFactory();
				case Dummy.EntityType.StockEntity:
					return new StockEntityFactory();
				case Dummy.EntityType.StockSectorEntity:
					return new StockSectorEntityFactory();
				case Dummy.EntityType.SummaryEntity:
					return new SummaryEntityFactory();
				case Dummy.EntityType.TransactionEntity:
					return new TransactionEntityFactory();
				case Dummy.EntityType.TransactionStatusEntity:
					return new TransactionStatusEntityFactory();
				case Dummy.EntityType.TransactionTypeEntity:
					return new TransactionTypeEntityFactory();
				case Dummy.EntityType.UserEntity:
					return new UserEntityFactory();
				default:
					return null;
			}
		}
	}
		
	/// <summary>Element creator for creating project elements from somewhere else, like inside Linq providers.</summary>
	public class ElementCreator : ElementCreatorBase, IElementCreator2
	{
		/// <summary>Gets the factory of the Entity type with the Dummy.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory2 GetFactory(int entityTypeValue) { return (IEntityFactory2)this.GetFactoryImpl(entityTypeValue); }
		
		/// <summary>Gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory2 GetFactory(Type typeOfEntity) { return (IEntityFactory2)this.GetFactoryImpl(typeOfEntity); }

		/// <summary>Creates a new resultset fields object with the number of field slots reserved as specified</summary>
		/// <param name="numberOfFields">The number of fields.</param>
		/// <returns>ready to use resultsetfields object</returns>
		public IEntityFields2 CreateResultsetFields(int numberOfFields) { return new ResultsetFields(numberOfFields); }
		
		/// <inheritdoc/>
		public override IInheritanceInfoProvider ObtainInheritanceInfoProviderInstance() { return ModelInfoProviderSingleton.GetInstance(); }

		/// <inheritdoc/>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand) { return new DynamicRelation(leftOperand); }

		/// <inheritdoc/>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, onClause);
		}

		/// <inheritdoc/>
		public override IDynamicRelation CreateDynamicRelation(IEntityFieldCore leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, string aliasLeftOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, aliasLeftOperand, onClause);
		}

		/// <inheritdoc/>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (Dummy.EntityType)Enum.Parse(typeof(Dummy.EntityType), rightOperandEntityName, false), aliasRightOperand, onClause);
		}

		/// <inheritdoc/>
		public override IDynamicRelation CreateDynamicRelation(string leftOperandEntityName, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation((Dummy.EntityType)Enum.Parse(typeof(Dummy.EntityType), leftOperandEntityName, false), joinType, (Dummy.EntityType)Enum.Parse(typeof(Dummy.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <inheritdoc/>
		public override IDynamicRelation CreateDynamicRelation(IEntityFieldCore leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (Dummy.EntityType)Enum.Parse(typeof(Dummy.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <inheritdoc/>
		protected override IEntityFactoryCore GetFactoryImpl(int entityTypeValue) { return EntityFactoryFactory.GetFactory((Dummy.EntityType)entityTypeValue); }

		/// <inheritdoc/>
		protected override IEntityFactoryCore GetFactoryImpl(Type typeOfEntity) { return EntityFactoryFactory.GetFactory(typeOfEntity);	}

	}
}