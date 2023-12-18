using FluentMigrator;
using Itmo.Dev.Platform.Postgres.Migrations;

namespace Lab5.Infrastructure.DataAccess.Migrations;

[Migration(2, "CreateAdmin")]
public class CreateAdmin : SqlMigration
{
    protected override string GetUpSql(IServiceProvider serviceProvider) =>
        """
    INSERT INTO admins (password)
    VALUES ('1234');
    """;

    protected override string GetDownSql(IServiceProvider serviceProvider) =>
        """
    DELETE FROM admins
    WHERE password = '1234';
    """;
}