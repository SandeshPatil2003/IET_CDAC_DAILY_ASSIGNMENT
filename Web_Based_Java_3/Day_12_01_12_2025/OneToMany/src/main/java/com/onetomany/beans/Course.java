package com.onetomany.beans;

import java.util.Set;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;

import javax.persistence.OneToMany;


@Entity(name="Course101")
public class Course {
		@Id
		@GeneratedValue
		private int cid;
		private String cname;
		
		@OneToMany(mappedBy="course")
		private Set<Student> sset;

		public int getcid() {
			return cid;
		}

		public void setcid(int cid) {
			this.cid = cid;
		}

		public String getcname() {
			return cname;
		}

		public void setcname(String cname) {
			this.cname = cname;
		}

		public Set<Student> getSset() {
			return sset;
		}

		public void setSset(Set<Student> sset) {
			this.sset = sset;
		}

		@Override
		public String toString() {
			return "Course [cid=" + cid + ", cname=" + cname + "]";
		}

		public Course(int cid, String cname, Set<Student> sset) {
			super();
			this.cid = cid;
			this.cname = cname;
			this.sset = sset;
		}
		
		public Course(String cname, Set<Student> sset) {
			super();
		
			this.cname = cname;
			this.sset = sset;
		}

		public Course() {
			super();
		}
		
		
		

	}


