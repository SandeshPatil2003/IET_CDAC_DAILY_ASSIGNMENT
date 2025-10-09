package com.quiz.service;

public interface QuizService {

	void addQuestion(int quizid);

	void loadQuiz(int quizid);

	void displayAll(int quizid);

	void displayUserOptions();

	void startUserQuiz(int quizid);

}
