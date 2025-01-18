SELECT top 10
    c.student_id, c.lesson_status, c.score_raw, c.SCORM_course_id, sc.title_from_manifest, u.Email, ss.startdatetime, 
    ss.enddatetime, um.dScore
FROM cmi_core c
    JOIN SCORM_Course sc on c.SCORM_course_id=sc.id
    JOIN AspNetUsers u on c.student_id=u.Id
    JOIN [session] ss on c.core_id=ss.cmi_core_id
    JOIN User_Module um on c.student_id=um.UserID and sc.id=um.SCORM_Courseid

------------------------------------------------------
SELECT --top 10
    --c.*
    --sc.*
    --u.*
    ss.*
    --distinct um.*
FROM cmi_core c
    JOIN SCORM_Course sc on c.SCORM_course_id=sc.id
    JOIN AspNetUsers u on c.student_id=u.Id
    JOIN [session] ss on c.core_id=ss.cmi_core_id
    JOIN User_Module um on c.student_id=um.UserID and sc.id=um.SCORM_Courseid