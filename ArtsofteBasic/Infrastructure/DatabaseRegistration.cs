// Decompiled with JetBrains decompiler
// Type: Microsoft.Extensions.DependencyInjection.DatabaseRegistration
// Assembly: Dis.Common.Db, Version=1.0.0.2, Culture=neutral, PublicKeyToken=null
// MVID: 6AEE20DC-2A02-4DE3-A7C1-EE8BC00725EB
// Assembly location: /Users/tanya/.nuget/packages/dis.common.db/1.0.0.2/lib/net6.0/Dis.Common.Db.dll

using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure;
using System;
using System.Data.Common;
using System.Globalization;
using System.Linq;


#nullable enable
namespace Microsoft.Extensions.DependencyInjection
{
  /// <summary>Методы регистрации БД</summary>
  public static class DatabaseRegistration
  {
    /// <summary>Дефолтная регистрация БД PostgresSql</summary>
    /// <typeparam name="TContext">Контекст БД для регистрации</typeparam>
    /// <param name="services">Где регистрируем (метод расширения)</param>
    /// <param name="dbDescription">Описание подключения к БД</param>
    /// <returns><see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /></returns>
    public static IServiceCollection AddDatabase<TContext>(
      this IServiceCollection services,
      DbDescription? dbDescription)
      where TContext : DbContext
    {
      return services.AddDatabase<TContext>(dbDescription, (ILoggerFactory) null, (Action<NpgsqlDbContextOptionsBuilder>) null, false);
    }

    /// <summary>Зарегистрировать БД PostgresSql c заданными параметрами</summary>
    /// <typeparam name="TContext">Контекст БД для регистрации</typeparam>
    /// <param name="services">Где регистрируем (метод расширения)</param>
    /// <param name="dbDescription">Описание подключения к БД</param>
    /// <param name="loggerFactory">Фабрика для журналирования (надо указать для перенаправления журнала в эластик, например)</param>
    /// <param name="contextBuilder">Фабрика контекста для задания параметров подключения к БД</param>
    /// <param name="isDetailedErrors">Включать детальные ошибки в лог или нет</param>
    /// <returns><see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /></returns>
    public static IServiceCollection AddDatabase<TContext>(
      this IServiceCollection services1,
      DbDescription? dbDescription,
      ILoggerFactory? loggerFactory,
      Action<NpgsqlDbContextOptionsBuilder>? contextBuilder,
      bool isDetailedErrors)
      where TContext : DbContext
    {
      if (dbDescription != (DbDescription) null)
        services1.AddSingleton<DbDescription>(dbDescription);
      services1.AddSingleton<DbConnectionStringBuilder>();
      services1.AddDbContext<TContext>((Action<IServiceProvider, DbContextOptionsBuilder>) ((services2, options) =>
      {
        }));
      return services1;
    }
  }
}
