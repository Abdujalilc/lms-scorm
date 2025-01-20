select
    scorm.title_from_manifest, scorm.pathToFolder
    ,core.student_id, core.lesson_location, core.score_raw
    ,inter.[type],inter.weighting,inter.student_response,inter.result
    ,cor_res.pattern
from SCORM_Course scorm
    JOIN cmi_core core on core.SCORM_course_id=scorm.id
    JOIN cmi_interactions inter on core.core_id=inter.core_id --get student response for each question
    JOIN cmi_interactions_correct_responses cor_res on inter.id=cor_res.interactions_id --get correct response
--where scorm.GuidId='15fe87e3-2d06-4574-96da-e390f6c7cbb2' and core.student_id=7
