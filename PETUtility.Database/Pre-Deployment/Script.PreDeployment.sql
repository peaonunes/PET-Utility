SET NOCOUNT ON;

use [$(DatabaseName)];

create table #deploy
( 
	LoadDatabaseDataIsRequired bit,
)

DECLARE @databaseExists BIT

-- Verifica se a base de dados precisa da execução de script de dados. Ela precisa de script de dados se for um deploy novo de banco
set nocount on;
if (exists (select top(1) TABLE_SCHEMA from information_schema.TABLES))
begin
	print '### Database already exists. Data import will not be necessary ###'
	SET @databaseExists = 0;
end
else
begin
	print '### Database re-created. Data importing will be performed ###'
	SET @databaseExists = 1;
end

insert into #deploy (LoadDatabaseDataIsRequired) values (@databaseExists)