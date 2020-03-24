using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SQL_Project
{
    class MyApplicationContext : ApplicationContext
    {
        public MyApplicationContext()
        {
            List<Form> forms = new List<Form>();
            forms.Add(new CustomerInterface());
            forms.Add(new StaffInterface());
            forms.Add(new RegistrationInterface());

            foreach (Form form in forms)
            {
                form.FormClosed += OnFormClosed;
            }
            foreach (Form form in forms)
            {
                form.Show();
            }
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                ExitThread();
            }
        }
    }
}
