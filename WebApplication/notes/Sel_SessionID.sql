IF EXISTS (SELECT
    1
  FROM sys.objects
  WHERE object_id = OBJECT_ID(N'dbo.Sel_SessionID')
  AND TYPE IN (N'P', N'PC'))
  DROP PROCEDURE dbo.Sel_SessionID
GO

-------------------------------------------------

CREATE PROCEDURE [dbo].[Sel_SessionID] 
@SCORM_Course_id int,
@SCO_ID varchar(1000),
@user_id nvarchar(450),
@sessionID nvarchar(100),
@core_id int,
@dtStartDateTime datetime

AS
BEGIN
  DECLARE @id int

  INSERT dbo.session (sessionid, [user_id], startdatetime, cmi_core_id, scorm_course_id, sco_identifier)
    VALUES (@sessionID, @user_id, @dtStartDateTime, @core_id, @SCORM_Course_id, @SCO_ID)
  SELECT
    @id = @@IDENTITY

  SELECT id, sessionid, user_id, startdatetime, enddatetime, SCORM_Course_id, SCO_identifier, cmi_core_id from dbo.session where id=@id
    
END