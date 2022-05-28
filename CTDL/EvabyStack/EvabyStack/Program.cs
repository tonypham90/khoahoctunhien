namespace EvabyStack;

// Chuyển đổi trung tố qua hậu tố



//---------------------
// Tính toán Hậu tố
public class StackNode
{
	public int Operand;
	public StackNode Next;
	public StackNode(int operand, StackNode top)
	{
		this.Operand = operand;
		this.Next = top;
	}
}
public class MyStack
{
	public StackNode Top;
	public int Count;
	public MyStack()
	{
		this.Top = null;
		this.Count = 0;
	}
	// Trả ề số trước khi vào stack
	public int IsSize()
	{
		return this.Count;
	}
	public bool IsEmpty()
	{
		if (this.IsSize() > 0)
		{
			return false;
		}
		else
		{
			return true;
		}
	}
	// Đối tượng stack
	public void Push(int value)
	{
		// Tạo 1 stack note và đặt trên top
		this.Top = new StackNode(value, this.Top);
		// Tăng thêm 1 node value
		this.Count++;
	}
	// Xoá stack node trên cùng trong stack
	public int Pop()
	{
		var value = this.Peek();
		if (this.IsEmpty() == false)
		{
			this.Top = this.Top.Next;
			// Reduce the size
			this.Count--;
		}
		return value;
	}
	// Sử dụng giá trị trên cùng của stack
	public int Peek()
	{
		if (!this.IsEmpty())
		{
			return this.Top.Operand;
		}
		else
		{
			return 0;
		}
	}
}
//Nhóm tính toán
public class Execution
{
	public void Evaluate(String e)
	{
		var size = e.Length;
		var a = 0;
		var b = 0;
		var s = new MyStack();
		var isVaild = true;
		// Phép tính
		for (var i = 0; i < size && isVaild; i++)
		{
			if (e[i] >= '0' && e[i] <= '9')
			{
				a = (int)(e[i]) - (int)('0');
				s.Push(a);
			}
			else if (s.IsSize() > 1)
			{
				a = s.Pop();
				b = s.Pop();
				// Đánh giá thứ tự ưu tiên giữa 2 operands
				if (e[i] == '+')
				{
					s.Push(b + a);
				}
				else if (e[i] == '-')
				{
					s.Push(b - a);
				}
				else if (e[i] == '*')
				{
					s.Push(b * a);
				}
				else if (e[i] == '/')
				{
					s.Push((int)(b / a));
				}
				else if (e[i] == '%')
				{
					s.Push(b % a);
				}
				else
				{
					// Dấu không thuộc operator
					isVaild = false;
				}
			}
			else if (s.IsSize() == 1)
			{
				// Trường hợp đặc biệt ký tự đầu tiên trong chuỗi là "+" hoặc "-"
				if (e[i] == '-')
				{
					a = s.Pop();
					s.Push(-a);
				}
				else if (e[i] != '+')
				{
					isVaild = false;
				}
			}
			else
			{
				isVaild = false;
			}
		}
		if (isVaild == false)
		{
			// Trường hợp biểu thức sử dụng phép tính khác:
			// 1) Sử dụng phép tính đặc biệt
			// 2) Phép tính không đúng
			Console.WriteLine(e + " Biểu thức không hợp lệ ");
			return;
		}
		Console.WriteLine(e + " = " + s.Pop());
	}
	
// Run
public static void Main(String[] args)
	{
		var task = new Execution();
		// Tính toán thử biểu thức // (1+2)*(3+5)
		task.Evaluate("12+35+*");
		// -((7*2) + (6/2) + 4)
		task.Evaluate("72*62/+4+-");
	}
}