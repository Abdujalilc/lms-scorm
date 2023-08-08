function DoSCORMBookmark(){
	var s="";
	s+=window.location;
	try{
		parent.SetBookmark(s);
	}
	catch(err){}
}

function SetLessonComplete(n){
	try{
		parent.SetLessonComplete(n);
	}
	catch(err){}
}

function SetLessonStarted(n){
	try{
		parent.SetLessonStarted(n);
	}
	catch(err){}
}

function GetLessonState(n){
	var v;
	try{
		v=parent.GetLessonState(n);
		return v;
	}
	catch(err){
		return "0";
	}
}

function DoComplete(){
	try{
		parent.SetCompleteFromChild();
	}
	catch(err){}
}

function GetStudentName(){
	var s;
	try{
		s=parent.GetStudentName();
	}
	catch(err){
		s="";
	}
	return s;
}