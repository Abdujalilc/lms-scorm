IF EXISTS (
SELECT 1 FROM sys.objects 
WHERE object_id = OBJECT_ID(N'dbo.Sel_CoreTrackingID') AND TYPE IN (N'P', N'PC')
) DROP PROCEDURE dbo.Sel_CoreTrackingID
GO

CREATE PROCEDURE [dbo].[Sel_CoreTrackingID] @SCORM_Course_id int, @UserID nvarchar(450)
AS
BEGIN
  DECLARE @core_id int
      SELECT TOP 1 @core_id = core_id FROM dbo.cmi_core
      WHERE student_id = @UserID AND SCORM_course_id = @SCORM_Course_id
      ORDER BY core_id DESC
  -- QUESTION about re-using cmi_core rows when they have completed a course
  IF @core_id IS NULL OR @core_id < 1
  BEGIN
    INSERT dbo.cmi_core (student_id, lesson_status, credit, lesson_mode, entry, SCORM_course_id)
      VALUES (@UserID, 'not attempted', 'credit', 'normal', 'ab-initio', @SCORM_Course_id)
    SELECT @core_id = @@IDENTITY
  END
  SELECT * FROM dbo.cmi_core WHERE core_id=@core_id   
END