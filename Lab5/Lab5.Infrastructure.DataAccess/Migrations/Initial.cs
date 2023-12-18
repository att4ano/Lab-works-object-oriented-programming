using FluentMigrator;
using Itmo.Dev.Platform.Postgres.Migrations;

namespace Lab5.Infrastructure.DataAccess.Migrations;

[Migration(1, "Initial")]
public class Initial : SqlMigration
{
    protected override string GetUpSql(IServiceProvider serviceProvider) =>
    """
    create type operation_type as enum
    (
        'withdrawal',
        'addition'
    );

    create table users
    (
        user_id bigint primary key generated always as identity,
        username text not null ,
        password text not null ,
        money bigint not null
    );

    create table admins
    (
        admin_id bigint primary key generated always as identity,
        password text not null
    );

    create table operations
    (
        operation_id bigint primary key generated always as identity,
        user_id bigint not null,
        operation_type operation_type not null,
        money bigint
    );
    """;

    protected override string GetDownSql(IServiceProvider serviceProvider) =>
    """
    drop table users
    drop table admins
    drop table operations
    
    drop type operation_type
    """;
}
