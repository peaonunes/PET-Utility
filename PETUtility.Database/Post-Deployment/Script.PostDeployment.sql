if ((select LoadDatabaseDataIsRequired from #deploy) <> 1)
begin
	set noexec on
	-- Desabilita a execução de instruções no SQL Server. Esta abordagem é necessária pois as instruções de SQLCMD (do tipo :r ...) 
	-- são SEMPRE executadas, mesmo estando compreendidas por um IF
end

:r .\Script.PostDeployment_InsertData.sql

drop table #deploy;
