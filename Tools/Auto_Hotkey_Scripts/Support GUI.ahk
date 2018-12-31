#SingleInstance, force

;Gui Layout
Gui, Show, w300 h300, Support Tool
Gui, Add, Button, w100 h50 gFindNum_Button, Find Account
Gui, Add, Button, w100 h50 gOpenPutty_Button, Open Putty/Move
Gui, Add, Button, w100 h50 gCodecBug_Button, Open Codec Bug
return


;Lables
CodecBug_Button:
	SetTitleMatchMode, 2
	IfWinExist Audian ahk_exe chrome.exe
	{
		
		WinActivate, Audian ahk_exe chrome.exe
		Msgbox, 1, Fix Codec, Would you like to fix the codec?
		IfMsgBox, OK
		{
			MStartX = 135
			MStartY = 272
			CheckAudio(MStartX, MStartY)
		}	
		return
	}
CheckAudio(MStartX, MStartY)
	{
	global
		MouseMove, %MStartX%, %MStartY% ;Moves cursor to the first device in the list.
		MouseClick, left,%MStartX%, %MStartY% ,1 , 55 ;Clicks 
		Sleep, 250
		MouseMove, 672, 256 ;Moves the mouse to Audio
		MouseClick, left,,,1 ,55 ;Clicks Audio
		
		Msgbox,3,,Would you like to fix?
			IfMsgBox, YES
			{
				MouseMove, 661, 501 ;Hover over G722.1 #1
				MouseClick, left,,,1,55 ;Clicks
				Sleep, 250
				MouseMove, 661, 526 ;Hover over G722.1 #2
				MouseClick, left,,,1,55 ;Clicks
				Sleep, 250
				MouseMove, 1192, 828 ;Hover over save
				MouseClick, left,,,1,55 ;Clicks
			
				Msgbox, 1,, Would you like to continue?
				IfMsgBox, OK ;Move to Next?
				{
					MStartY += 25 ;Increases Y
					CheckAudio(MStartX, MStartY)
				}
				IfMsgBox, CANCEL
				{
					Return
				}
				Return	
					}
					IfMsgBox, NO
					{
						MStartY += 25
						CheckAudio(MStartX, MStartY)
					}
					IfMsgBox, CANCEL
					{
						Return
					}
	}	

AutoFix()
	{
	global
		MouseMove, 650, 495 ;Hover over G722.1 #1
		MouseClick, left,,,1,55 ;Clicks
		Sleep, 500
		MouseMove, 650, 518 ;Hover over G722.1 #2
		MouseClick, left,,,1,55 ;Clicks
		Sleep, 500
		MouseMove, 1174, 812 ;Hover over save
		MouseClick, left,,,1,55 ;Clicks
		
		Msgbox, 1,, Would you like to continue?
		IfMsgBox, OK ;Move to Next?
		{
			MStartY += 30 ;Increases Y
			CheckAudio(MStartX, MStartY)
		}
		IfMsgBox, CANCEL
		{
			Return
		}
		Return
	}
	
	
OpenPutty_Button:
	IfWinExist ec2-user@kml02:~
	{
	WinActivate
	WinMove, ec2-user@kml02:~,,2530, 94, 659, 425
	}
	Else
	{
	Run putty.exe, C:\Program Files (x86)\Putty
	}
	Return



FindNum_Button:
	InputBox, phoneNumber, Account Lookup, Please enter the number for the account.,, 300,150, ,
	phoneNumber = %phoneNumber%
	NumCount := phoneNumber
	NumCount := StrLen(NumCount) 
	if (NumCount != 10)
	{
		Msgbox, Invalid Number
		return
	} 
	else
	{ 
		msgbox, Looking Up Account %phoneNumber%
		NumLookUp(phoneNumber)
	}
	
	
	return

;Functions
NumLookUp(phoneNumber)
{
	WinActivate, ec2-user@kml02:~
	sleep, 1000
	send, number_tree %phoneNumber%
	;msgbox, %phoneNumber%
	return
}

;Hotkeys

;Ticket Template
::tt*::
send, Customer:{enter}Call Back:{enter}Company:{enter}Issue:{enter}
return

;Provisioning
::d#::
send,{space}provisioner2.cfg,
return


::dl*::
send, document.getElementsByClassName("second-line") {enter}
sleep, 2000
send, var macNumList = document.getElementsByClassName("second-line") {enter}
sleep, 2000
Clipboard = for (i=1; i < macNumList.length; i+=2){{} var macList = macList + document.getElementsByClassName("second-line")[i].textContent + "\n"; {}} console.log(macList); 
send ^v {enter}
InputBox, macList, Paste MAC list here
msgbox,0,,macList


return




^x::ExitApp