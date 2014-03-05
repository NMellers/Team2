public static var review = false;
public static var reviewOne : String = "";
public static var reviewScore : String = "";
public static var submittedReviewOne : String = "";
public static var scoreOne : String = ""; 

function Start () 
{

}

function Update () 
{
	
}

function OnMouseDown ()
{
	review = true;
	Debug.Log(review);
	
}

function OnGUI()
{

	if(review == true)
	{
	
	// Creates an Editable Text Box. The entered text is set to reviewOne string.
	
		reviewOne = GUI.TextArea(Rect(30,30,170,150), reviewOne, 140);
		
	// Creates a text box where the player can input the score, saces to variable.
		
		reviewScore = GUI.TextField(Rect(110,187,30,30), reviewScore, 2);
		
		
	// Creates a button that will save the textbox string to submittedReviewOne variable.
	// The text is then cleared.
	
		if(GUI.Button(Rect(35,190,60,30), "Submit"))
			{
				
				submittedReviewOne = reviewOne;
				reviewOne = "";
		// Sets the review score to the string entered in the ?/10 box.
				scoreOne = reviewScore;
				reviewScore = "";
		// returns back to "Games" menu.
				review = false;
			}
		
			
	}
	
}