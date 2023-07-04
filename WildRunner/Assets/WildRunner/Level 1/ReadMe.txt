GameOver.cs use on (Use camera y position to detected is it Gameover)
-Controller -> CameraSetup -> VietualCamera

LoadingScreen.cs use on (Display the Loading Screen a few second then destroy the loading screen)
-Canvas -> Debug -> ClimbReady -> Loading

Lv1EndGame.cs use on (Destroy each player hit point and have debug score function)
-CheckPointManager->FinishCheckPoint
-CheckPointManager->AerobaticsCheckPoint1
-CheckPointManager->AerobaticsCheckPoint2
-CheckPointManager->AerobaticsCheckPoint3
-CheckPointManager->AerobaticsCheckPoint4

ScoreDisplay.cs use on (Calculate and display the score)
-Canvas -> Debug -> ClimbReady -> Timer -> ScoreDisplay

Timer.cs use on (Show timer, Gameover or Victory will stop)
-Canvas -> Debug -> ClimbReady -> Timer

TimerDisplay use on (This script make Loading Screen will not display timer)
-GameManager