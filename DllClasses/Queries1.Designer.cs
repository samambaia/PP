using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;

namespace DllClasses
{
public static partial class Queries1
{
public static System.Linq.IQueryable<DllClasses.Net.Sistema.Negocio.cfop> NewQuery(System.Data.Linq.DataContext context)
{
return (	from CFOP in context.GetTable<DllClasses.Net.Sistema.Negocio.cfop>()
	select CFOP);
}

}
}
