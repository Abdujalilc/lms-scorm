var rootFolder = "";

function keyUpLocal(e) {
	//if (nextActive) return;
	if (document.getElementById('Q1a').disabled) return;
	if (window.event) {
		var keynum = e.keyCode;
	} else if (e.which) {
		var keynum = e.which;
	}
	var keychar = String.fromCharCode(keynum);
	if (keynum == 13) {
		judge();
		return;
	}
	var keychar = String.fromCharCode(keynum);
	if ((keynum >= 65) && (keynum <= 64+choices)) {
		document.getElementById('Q1' + keychar.toLowerCase()).checked = true;
		choiceSelected();
		return;
	} else if (keynum == 13) {
		judge();
		return;
	}
}

function enableSubmit(enable) {
	if (enable) {
		//document.getElementById('submit').src = rootFolder + "images/interface/btn_Submit_up.png";
		//document.getElementById('submit').alt = "Submit";
		$("#submit").attr({alt: "Submit", src: rootFolder + "images/interface/btn_Submit_up.png"}).css("cursor","pointer");
	} else {
		//document.getElementById('submit').src = rootFolder + "images/interface/btn_Submit_dim.png";
		//document.getElementById('submit').alt = "Submit (inactive)";
		$("#submit").attr({alt: "Submit (inactive)", src: rootFolder + "images/interface/btn_Submit_dim.png"}).css("cursor","default");
	}
}

function enterPageLocal() {
	enableSubmit(false);

	if (checkLinkDone(1)) {
		showAnswers();
		activateNext();
	}
}

function choiceSelected() {
	enableSubmit(true);
}

function judge() {
	if (document.getElementById('submit').alt == "Submit (inactive)") {
		alert("The submit button is currently inactive.  Please read the screen for instructions.");
		return;
	}

	studentResponse = "";
	for (var i=65; i<=64+choices; ++i) {
		var ltr = String.fromCharCode(i).toLowerCase();
		if (document.getElementById('Q1' + ltr).checked) {
			studentResponse = ltr.toUpperCase();
		}
	}

	if (studentResponse == "") {
		return;
	}

	if (studentResponse == correctResponse) {
		showAnswers();
		//document.getElementById('qFeedback').innerHTML = FDBK_correct;
		//$("#qFeedback").html(FDBK_correct).focus();
		popUp("Feedback", FDBK_correct);
		finishQuestion();
	} else {
		if (choices==2) {
			showAnswers();
			//document.getElementById('qFeedback').innerHTML = FDBK_incorrect_1;
			//$("#qFeedback").html(FDBK_incorrect_1).focus();
			popUp("Feedback", FDBK_incorrect_1);
			finishQuestion();
		} else if (FDBK_count==1) {
			showAnswers();
			//document.getElementById('qFeedback').innerHTML = FDBK_incorrect_2;
			//$("#qFeedback").html(FDBK_incorrect_2).focus();
			popUp("Feedback", FDBK_incorrect_2);
			finishQuestion();
		} else {
			FDBK_count++;
			enableSubmit(false);
			//document.getElementById('qFeedback').innerHTML = FDBK_incorrect_1;
			//$("#qFeedback").html(FDBK_incorrect_1).focus();
			popUp("Feedback", FDBK_incorrect_1);
		}
	}
}

function showAnswers() {
	var row = correctResponse.charCodeAt(0) - 65;
	//document.getElementById('questionChoices').rows[row].cells[0].innerHTML = "&#x2713;";
	document.getElementById('questionChoices').rows[row].cells[0].innerHTML = "&#x2714;";
}

function finishQuestion() {
	enableSubmit(false);
	var ltr = "";
	for (var i=65; i<=64+choices; ++i) {
		ltr = String.fromCharCode(i).toLowerCase();
		document.getElementById('Q1' + ltr).disabled = true;
	}
	activateNext();
	addToPagesViewed(pageName);
	//setLinkComplete(1);
}
