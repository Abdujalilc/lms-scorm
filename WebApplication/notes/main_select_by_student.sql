SELECT
    distinct c.core_id, c.student_id, c.lesson_status, c.score_raw, c.score_min, c.score_max, c.SCORM_course_id
    , ss.id, ss.user_id, ss.startdatetime, ss.enddatetime, ss.SCORM_Course_id, ss.cmi_core_id
    , i.id, i.interaction_time, i.[type], i.weighting, i.student_response, i.result, i.core_id
    , r.id, r.interactions_id, r.pattern
    , sc.id, sc.GuidId, sc.pathToIndex, sc.pathToFolder, sc.DateUploaded, sc.SCORM_version, sc.ModuleID, sc.AcademicYaer
    , u.ID, u.FirstName, u.LastName, u.Email, u.UserName  
    , um.id, um.UserID, um.UserName, um.SCORM_Courseid, um.dScore
FROM cmi_core c --student assessment 
    JOIN [session] ss on c.core_id=ss.cmi_core_id --student attempt time and hours
    JOIN cmi_interactions i on c.core_id=i.core_id --student result for each question
    JOIN cmi_interactions_correct_responses r on i.id=r.interactions_id --correct answers of assessment
    JOIN LM.SCORM_Course sc on c.SCORM_course_id=sc.id --main scorm info like name, path, folder ...
    JOIN [User] u on c.student_id=u.Id --intranet identity user
    JOIN LM.User_Module um on c.student_id=um.UserID and sc.id=um.SCORM_Courseid --final score by user, scorm, acadyear
WHERE sc.id=106 and c.student_id=16882
ORDER BY sc.id,c.student_id,c.core_id