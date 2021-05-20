public class User
{
	public Long Id {get;set;}
	public string FirstName{get;set;}
	public string LastName{get;set;}
	public string Email{get;set;}
	public string Country{get;set;}
	public string State{get;set;}
	public string City{get;set;}
	public string Gender{get;set;}
	public string Mobile{get;set;}
	public string Serial{get;set;}
	public string PostCode{get;set;}
	public string Address{get;set;}
	public string Father{get;set;}
	public string Phone{get;set;}
	public bool IsSingle{get;set;}
	public string Certificate{get;set;}
	public string Lesson{get;set;}
	public string Job{get;set;}
	public string Bio{get;set;}
	//relations--->

	public List<Course> Courses {get;set;}
	public List<Learning> Learnings {get;set;}
}

public class Course
{
	public long Id {get;set;}
	public string Title{get;set;}
	public string Description{get;set;}
	public string Image{get;set;}
	public long Count{get;set;}
	public long CountSessions{get;set;}
	public string Times {get;set;}
	public string Certificate {get;set;}
	public string Price {get;set;}
	public string Audience {get;set;}
	public string SupportDevice {get;set;}
	public string days{get;set;}
	public string Content{get;set;}
	public string Discount{get;set;}
	public string PriceWithDiscount{get;set;}
	public bool IsActive{get;set;}
	// relations --->

	public List<Clip> Clips {get;set;}

	public List<HeaderAndSubs> HeadersAndSubs {get;set;}

	public List<Feature> Features {get;set;}
}

public class Clip
{
	public long Id {get;set;}
	public string ClipUrl {get;set;}

	//relations 
	
	public Course Course {get;set;}
	public long CourseId {get;set;}

}

public class HeaderAndSubs
{
	public long Id {get;set;}
	public List<Sub> Subs {get;set;}
}

public Class Sub
{
	public long Id {get;set;}
	public string SubName{get;set;}
	public string fileName {get;set;}

	//relations

	public HeaderAndSubs HeaderAndSubs {get;set;}
	public long HeaderId {get;set;}

}
public class Feature
{
	public long Id {get;set;}
	public string Name {get;set;}
	public string Value {get;set;}
	public Image {get;set;}
}

public class Teacher
{
	public long Id {get;set;}
	public string FirstName {get;set;}
	public string LastName{get;set;}
	public string Certificate{get;set;}
	public string Description {get;set;}
	public DateTime? Birthday {get;set;}
	public string Place{get;set;}
	public string Biography{get;set;}
	
	//relations--->
	
	public List<Article> Articles {get;set;}

	public List<Messenger> Messengers {get;set;}

	public List<CV> CVes {get;set;}
}

public class Article
{
	public long Id {get;set;}
	public string Name {get;set;}
	public string Description {get;set;}
	public string content {get;set;}
	public string Image {get;set;}
	public DateTime Date {get;set;}
	public string Author {get;set;}

	//relations

	public Teacher Teacher {get;set;}
	public long TeacherId {get;set;}

}

public class Messenger
{
	public long Id {get;set;}
	public string Title {get;set;}
	public string Content {get;set;}
	public List<Clip> Clips {get;set;}
	public string Image {get;set;}

	//relations
	
	public Teacher Teacher {get;set;}
	public long TeacherId {get;set;}
}

public class CV
{
	public long Id {get;set;}
	public string Description {get;set;}
	public string Image{get;set;}	

	//relations 	

	public Teacher Teacher {get;set;}
	public long TeacherId {get;set;}
}

public class Question
{
	public long Id {get;set;}
	public string Ask{get;set;}
	public string Answer{get;set;}	
}

public class Comment
{
	public long Id {get;set;}
	public string Title {get;set;}
	public string Content {get;set;}
	public DateTime Date {get;set;}
	public List<Answer> Answers {get;set;}
}

public class Answer
{
	public long Id {get;set;}
	public string content {get;set;}
	
	//relations

	public Teacher Teacher {get;set;}
	public long TeacherId {get;set;}


}

public class Certificate
{
	public long Id {get;set;}
	public string Title {get;set;}
	public string Content {get;set;}
	public string Image {get;set;}

	//relations 

	public Teacher Teacher {get;set;}
	public long TeacherId {get;set;}
}

public class Lesson
{
	public long Id {get;set;}
	public string Name {get;set;}
	public string Image {get;set;}
	
	//relations
	
	public Teacher Teacher {get;set;}
	public long TeacherId {get;set;}
}







