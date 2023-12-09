namespace les_petits_cakes.Services;

public class ToastOptions
{
  public ToastOptions(string title, string content)
  {
    Title = title;
    Content = content;
  }

  public ToastOptions(string message)
  {
    Title = message;
    Content = string.Empty;
  }

  public string Title { get; set; }
  
  public string Content { get; set; }
}

public class ToastService
{

  public event Action<ToastOptions>? OnShow;

  public void ShowToast(ToastOptions options)
  {
    OnShow?.Invoke(options);
  }
}