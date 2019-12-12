--Logon trigger

select * from sys.dm_exec_sessions
exec sp_readerrorlog

alter trigger tr_AuditLogin
on all server for LOGON
AS
Begin
	declare @LoginName nvarchar(100)
	set @LoginName = ORIGINAL_LOGIN()

	if(select count(*) as 'Open conections' from sys.dm_exec_sessions
	where is_user_process = 1 and original_login_name = @LoginName) > 3

	Begin
		print 'Fourth connectio attempt by ' + @LoginName
		--rollback
	End
End

disable trigger tr_AuditLogin on all server