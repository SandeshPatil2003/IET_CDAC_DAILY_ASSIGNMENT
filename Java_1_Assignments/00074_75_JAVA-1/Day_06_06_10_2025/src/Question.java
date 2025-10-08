import java.util.Arrays;

public class Question {

	private int qNo;
	private String qText;
	private String[] qOptions;
	private String ans;
	@Override
	public String toString() {
		return "Question [qNo=" + qNo + ", qText=" + qText + ", qOptions=" + Arrays.toString(qOptions) + ", ans=" + ans
				+ ", marks=" + marks + "]";
	}
	private double marks;
	
	
	public Question() {
		super();
	}
	
	
	public Question(int qNo, String qText, String[] qOptions, String ans, double marks) {
		super();
		this.qNo = qNo;
		this.qText = qText;
		this.qOptions = qOptions;
		this.ans = ans;
		this.marks = marks;
	}
	
	
	public int getqNo() {
		return qNo;
	}
	public void setqNo(int qNo) {
		this.qNo = qNo;
	}
	public String getqText() {
		return qText;
	}
	public void setqText(String qText) {
		this.qText = qText;
	}
	public String[] getqOptions() {
		return qOptions;
	}
	public void setqOptions(String[] qOptions) {
		this.qOptions = qOptions;
	}
	public String getAns() {
		return ans;
	}
	public void setAns(String ans) {
		this.ans = ans;
	}
	public double getMarks() {
		return marks;
	}
	public void setMarks(double marks) {
		this.marks = marks;
	}
	
	
	
	
	
}
