using System;

namespace Chama.Data
{
	public interface IEntityFactory
	{
		object Create(Type type);
	}
}
