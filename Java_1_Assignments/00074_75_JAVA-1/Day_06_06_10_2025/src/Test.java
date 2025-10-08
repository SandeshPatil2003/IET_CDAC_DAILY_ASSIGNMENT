

import java.util.Arrays;
import java.util.Date;

public class Test {

	private int tId;
	private String tName;
	private Date tDate;
	private Question [] qlist;
	
	
	public Test() {
		super();
	}


	@Override
	public String toString() {
		return "Test [tId=" + tId + ", tName=" + tName + ", tDate=" + tDate + ", qlist=" + Arrays.toString(qlist) + "]";
	}


	public int gettId() {
		return tId;
	}


	public void settId(int tId) {
		this.tId = tId;
	}


	public String gettName() {
		return tName;
	}


	public void settName(String tName) {
		this.tName = tName;
	}


	public Date gettDate() {
		return tDate;
	}


	public void settDate(Date
			tDate) {
		this.tDate = tDate;
	}


	public Question[] getQlist() {
		return qlist;
	}


	public void setQlist(Question[] qlist) {
		this.qlist = qlist;
	}


	public Test(int tId, String tName, Date tDate, Question[] qlist) {
		super();
		this.tId = tId;
		this.tName = tName;
		this.tDate = tDate;
		this.qlist = qlist;
	}
	
	
	

}
