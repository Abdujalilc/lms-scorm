IF EXISTS (SELECT
    1
  FROM sys.objects
  WHERE object_id = OBJECT_ID(N'dbo.Sel_CoursesWithUserIndicator')
  AND TYPE IN (N'P', N'PC'))
  DROP PROCEDURE dbo.Sel_CoursesWithUserIndicator
GO

-----------------------------------------

CREATE PROCEDURE [dbo].[Sel_CoursesWithUserIndicator] @userID nvarchar(450)
AS
BEGIN
  SELECT sc.id,
         title_from_manifest AS title,
         pathtoIndex,
         DateUploaded,
         COALESCE(um.id,0) as user_module_id FROM SCORM_Course sc
  LEFT JOIN User_Module um
    ON sc.id = um.SCORM_Courseid
    AND um.UserID = @userID
  ORDER BY title_from_manifest
END