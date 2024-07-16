namespace BlazorTraining239711.Components.Pages.modul4
{
    public class ChatVM
    {
        public List<Nachricht> Liste { get; set; } = new List<Nachricht>();
        public event Action OnAdd;
        public void Add(string msg)
        {
            Liste.Add(new Nachricht { Text = msg });
            OnAdd?.Invoke();
        }

    }
}
