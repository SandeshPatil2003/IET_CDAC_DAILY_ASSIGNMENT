package com.quiz.beans;

public class Question {
	
	private int qid;
	private String ques;
	private String ans;
	

	public Question() {
		super();
	}
	public Question(int qid, String ques, String ans) {
		super();
		this.qid = qid;
		this.ques = ques;
		this.ans = ans;
	}
	public int getQid() {
		return qid;
	}
	public void setQid(int qid) {
		this.qid = qid;
	}
	public String getQues() {
		return ques;
	}
	public void setQues(String ques) {
		this.ques = ques;
	}
	public String getAns() {
		return ans;
	}
	public void setAns(String ans) {
		this.ans = ans;
	}
	
	
	@Override
	public String toString() {
		return "Question [qid=" + qid + ", ques=" + ques + ", ans=" + ans + "]";
	}
	
	

}
