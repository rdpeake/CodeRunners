/*
Key gameplay idea
	Need to use codeing from basic to advanced in order to complete the game
		allow for different code languages (C#, VB.net, VBA, python, java, javascript, etc)
		Possible Languages:
			-C# (internal compiling) - true forms dialog
			-VB.net (internal Compiling) - true forms dialog
			-Java (requires JDK and external javac call) - true forms dialog
			-Python (requires Python installed and external python call with source file) - true python dialogs

			-C++*
			-VBA*
			-Javascript**

			EARLYGAME:
				-Assebly (PIC or MIPS) [manual interpretation or object from string]
				-Custom simplified language syntax [manual interpretation or object from string]

		*May require additional package installs or files or even independant interpreter...
		**May require independant interpretor or non-conventional use of the web browser object...
	also combines with 'fighting' and EXP gain to complicate idea
	give real world use examples for coding

needs to have a story line -> perhaps similar to the professor layton games
Back Story:
	Take place in a world where Personal Computers and Calculators don't exist.
	In order to Simplify real world problems a group of people know as 'Code Runners' go around with an expensive and limited device which
		Once programmed will perform like a batch style Computer of the known world.
		These devices are designed that they only work with 1 style of programming language.

	At times one Code Runner may be needed to help out another Code Runner with problems -> either with multiple choice answers or short answer ones

	Initially This programming language is not a known programming language but a significantly limited one also the program size is limited.
	Optionally you can choose to use 'assembly' instead of the basic programming language as a starting point.
	As you progress through the game the storage and Abilities of the devices increases. Depending on the langage chosen (once the device is powerfull enough to use
	such a language) it may even allow you to input your own commands (External Button, Device Button, Char style, Command Line style, GUI Style)
	Along with the Language power increase, the capabilities to 'debug' and 'step through' can be added rather than the device 'blowing up' when the code is wrong.
	Also A syntax checker may be added as well (one of the first few things added).
	Other upgrades can come to the editor interface such as 'intelisense' or other helpful autocomplete.
	*/
#region Story Line:
/*
*/
#endregion

#region Potential 'puzzles':
/*
	Multiple Choice -> language dependant as well as generic programmer type;
	Short answer -> what is the output, what line is missing, how is such and such interpretted
	Error Correction, Syntactical, Runtime and incorrect output;
	Single Method Writting:
			eg. method takes x,y,z as input and produces a,b,c as output -> write this code
			Turn Power on and method runs...
	Multiple Method Writting -> with method Declaration ^same format as above
			Like Interupts?
			Method call every time data changes?
	Class Based writing -> automated stdin stdout stuff
	Class Based writing -> non-Automated input producing expected output
	Forms Based writing -> writing a userform (for supported languages) producing expected output or 'proxy/network' based commands to ansswer question
	Any version of the Automated styles with timing built in
	Threaded based questions -> multiple choice and coding
		May include writting a class which can handle the threading
		could involve writing the 'dispatcher' that handles dividing a task to thread objects
		could involve writing both objects
	Client and/or Server style class interaction

Potential 'fighting':
	A type of battle where you must program something to prevent an 'attack' from reaching?
	Potentially incorporate support characters to give alternatives to programming?
	Potentially have 'method of completion' change the flow of the game

Try to make the Game into an 'Engine' with 'Puzzle' files to allow for no-programing based addition (support programs may be required) and to allow for
sequals if possible.

Game Items:
	Puzzle Hint Token:
		used to show Hints based to give help for text part of question (depends on question)
	Code Hint Token:
		used to show Hints for code based parts -> such as tips for how to answer certain questions
	Code Pass Token:
		Used to allow limited parts of code to just 'work' if they are part of the expected program
 * 
 */
#endregion
		/*
Game Window Ideas (forms):
	[x] Splash and Welcome form;
	Dialog form -> incorporates displaying of messages, Images/Videos and dialog user responses (yes/no other non-puzzle based input);
	{
		Options or 'Trunk' menu -> links to settings and allows save
		Main Game World -> 2d click direction style game with back image
	} May actually incorpatee the previous 'form' as a control instead;

	Puzzle Host
		For all questions it shows hints if asked for and available (hint tokens of some form will be found in main world and give as rewards)
		For multiple choice or non coding questions displays the question and an answer or a space for an answer
		for coding questions it shows a discription of the puzzle and an option to open the editor

	Puzzle Code Editor
		Shows an Editor for writing code including 'uneditable' sections depending on the format of the question
		has option to display the puzzle descritption and hints
		Has option for Code Hints or Code Passes based on tokens found or rewared throughout the game (Game Passes make sections of code just 'work')

	Puzzle Code Debug Window (Depending on editor form code, could be part of same form)
		Used for debugging code that has either been asked to be debugged or encounters an error

	Puzzle Code Execution Window (May be part of Editor)
		Will allow for command line user input
		Will display any user forms made

	'Fight' games windows??
		Area for playing the fight games


*/
#region game data ideas
/*
the editors will be designed so that they create code directly in the %buildpath%/data directories for which they are the editor for.

all of this is in the data directory.

Level and story line stuff
	levels will be stored in the level directory, each level will have a folder. within that folder will be either sublevel folders or map folders
		these can have condtional stuff in them

	Story line data will be stored in the data root directory and will govern how things are done when level ups occur (advancement chosen or when it can be chosen)
		this will be a dll of some form, loaded at load and will inherit or implement some interface.

Save works
	All game saves will be in the Saved Games directory (independant of the Data directory)
		a game will only have 1 save file for it (though users could move them around if they so desired)

	global options (those not meant for independant preferencing) will be stored in the root directory with the exe.

Cutsceenes
	All cutsceen data will be stored in the cutsceen directory
	each cutsceen has its own directory within that containing any videos or dialogs it uses

Dialogs
	non-cutsceene dialog will be stored in the dialogs directory

Videos works
	non-cutsceene videos will load from videos directory
	*/
#endregion

#region Images works
/*all images will be loaded from the directory 'images'
	Sceene images will be loaded from the 'sceens' directory
	Character images will have 2 representations (whole and face) and will load from 'Character' subdirectory
		format for these will be NUMBER.face or NUMBER.whole for face and whole images of character number NUMBER, respectively
*/
#endregion

#region puzzle works...
/*puzzles will be saved as ID.puzzle (will probably be a folder depending on what needs to be stored)
	puzzles will be saved in 'puzzles/common' or 'puzzles/LANG' directories depending if they are language independant or dependant respectively
		LANG will be a representation of the selectable languages in the game.

	when puzzles are loaded, they will check the 'LANG' directory for the ID of the puzzle (which is in fact its numerical listing) before it checks the 'common' directory.
		If neither folder holds a puzzle, a message dialog will be displayed telling of puzzle errors, and after acknowledgement will proceed as if you have 'canceled' out of the puzzle

*/
#endregion

#region Language works:
/*	Has Language files loading -> can use my tool or visualstudio to make the dlls used
	Language can only be changed from the Home menu...
	you will only be able to select languages which have a 2 letter dll file in the root lang folder. 'en' will always be loaded if available.
	this does not need to be a valid .dll though... :(

{$...} find and replace ... when in this context.
... syntax,
	global scope pulls from a language file in lang folder ('en' by default).
	namespaces can be used, sperated by '.' and are located in lang/namespace/**.txt(ini,xml??)
		look into making this a dll file with a certain interface which will interface with the global language stuff, if this is beneficial!
	examples
	{$yes} loads yes string from lang/**.txt
	{$puzzles.string1} loads string1 from lang/puzzles/**.txt

	if match not found, will strip {$} and '_'s from ...
	eg: {$visible_if_not_found} will print as 'visible if not found' if there is no key 'visible_if_not_found' in the language structure.
		if a language other than english is selected, and no match is found in the active language, the english laguage is checked before printing the no key structure.

	there will be a way to gain access to this for puzzle solution code, there will be no length limit for strings (well maybe...)

	** in the above is the two letter language code standard to be offered in the laguage selection list.
	to work with this, make sure all text display breaks things based on displayed text, not pre-determined values.

	{@...} will be replaced will a 'variable' eg {#name}
	{${@...}...} #... will be evaluated then used for the {$...} evaluations.
	potential example {${#gender}.single} could evalueate to male.single or female.single which would be him or her...
 * 
 * {#FFFFFFFF}...{/#} shows ... with the colour #FFFFFFFF
*/
#endregion

#region FIRST STEP!!!
	/*get things working without puzzles at all... simply bypass the puzzles and get the rest working

	begin i suppose with the opening cut sceene and the collecting of player name and maybe gender. use this to work out what the cutsceen and dialog stuff needs to have.

	construct levels.
*/
#endregion