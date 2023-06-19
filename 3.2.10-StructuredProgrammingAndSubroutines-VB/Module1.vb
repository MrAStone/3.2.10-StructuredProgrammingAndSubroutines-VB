Module Module1

    Sub Main()
        Dim a As Integer = IntFunctionReturner() 'function call and store return value in variable a
        Dim b As Integer = AddTwoNumbers(3, 4) ' function call with paramters 3 and 4 and stores return value in b
        b = AddTwoNumbers(a, b) ' Function Call With parameters being two variables And stores Return value In b
        b = AddTwoNumbers(a, 231) ' Function Call With one parameter being a variable And the other a value, store Return value In b
        Console.WriteLine(getResponseFromUser()) 'output Return value Of Function Call

    End Sub
    Function IntFunctionReturner() As Integer
        Return 10 ' returns the value 10
    End Function
    Function AddTwoNumbers(a As Integer, b As Integer) As Integer
        Return a + b ' adds the values of parameters a and b and returns the value
    End Function
    Function getResponseFromUser()
        Dim response As String ' local variable - destroyed when function ends
        Console.Write("Enter something for this function to return: ")
        response = Console.ReadLine
        Return response
    End Function
    Function validInput(input As Integer, lower As Integer, upper As Integer) As Boolean
        If input >= lower And input <= upper Then
            Return True ' once value is returned function ends
        End If
        Return False ' only gets here if no return value given
    End Function
    ' procedures in VB are called SUB
    Sub thisIsAProcedure()
        Console.WriteLine("I don't return anything")
        Console.WriteLine("I just do what I need to do")
    End Sub

    Sub procedureWithParameters(first As String, second As String)
        Console.WriteLine($"The values passed into this procedure are {first} and {second}")
    End Sub
    Sub procedureWithLocalVariabls(a As Integer, b As Integer, s As String)
        Dim result As Integer = 0 'local variable
        For i = 0 To a
            result += b
        Next
        Console.WriteLine($"{s} is a passed in parameter and {result} is local")
        Console.WriteLine($"Once this procedure finishes, {result} no longer exists in the program")
        Console.WriteLine("This makes my program more efficient as it only uses memory when needed")
        Console.WriteLine("If i used global variables, they would allways exist in memory when the program runs")

    End Sub

End Module
