# c-sharp-hw-day1
C# homeworks for day 1

# Build
- Use VS2019 or `dotnet build`
- Allow elevated prompt to run in order to create the links for this project. This hard links will allow you to run each homework as an separated executable.

# Run
1. Available homeworks: `FirstHW`, `SecondHW`, `ThirdHW`, `FourthHW`, `FifthHW` and you guessed `SixthHW`
2. In windows: 
	- execute `Homework [Homework name] [Homework params]`
	- or you can run each Homework as a separate executable `FirstHW params`
3. In Linux:
	- execute `mono Homework.dll [Homework name] [Homework params]`
	- or you can create symbolic links with the name of each homework `ln -s Homework.dll FirstHW.dll` and then run `mono FirstHW.dll params`

**There is no data hard coded in executable so for each homework you need to provide some. Use `/?` to display the help.
After each run the program awaits a key to exit.
The homeworks names are case sensitive.**
