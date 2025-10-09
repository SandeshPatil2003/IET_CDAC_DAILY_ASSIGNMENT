package com.quiz.beans;

import java.util.Arrays;

//////Problem Statement: Create a console-based quiz application.
//The administrator can:
////Load questions and answers from a file.
////Add new questions.
////The user can then take the quiz:
////Questions are presented one by one.
////The user's score is tracked and displayed at the end. 
////SoC Focus: Separate the QuizService (handling quiz logic) 
//from the QuestionRepository (loading and saving questions to
//		a file). The Question class holds question data.
////

public class Quiz {
	
	private int quizid;
	private String quiznm;
	private Question [] qlist;
	

	
	public Quiz() {
		super();
	}
	public Quiz(int quizid, String quiznm, Question[] qlist) {
		super();
		this.quizid = quizid;
		this.quiznm = quiznm;
		this.qlist = qlist;
	}
	
	
	
	@Override
	public String toString() {
		return "Quiz [quizid=" + quizid + ", quiznm=" + quiznm + ", qlist=" + Arrays.toString(qlist) + "]";
	}
	
	
	public int getQuizid() {
		return quizid;
	}
	public void setQuizid(int quizid) {
		this.quizid = quizid;
	}
	public String getQuiznm() {
		return quiznm;
	}
	public void setQuiznm(String quiznm) {
		this.quiznm = quiznm;
	}
	public Question[] getQlist() {
		return qlist;
	}
	public void setQlist(Question[] qlist) {
		this.qlist = qlist;
	}
	
	

}
