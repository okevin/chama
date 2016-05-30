using System;

namespace Chama.Data
{
	internal interface IQueryTypeHandler<TEntity>
	{
		bool IterateDataReader { get; }
		object HandleType(Action<TEntity, IDataReader> customMapperReader, Action<TEntity, dynamic> customMapperDynamic);
	}
}