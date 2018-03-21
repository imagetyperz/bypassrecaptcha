using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace imagetyperz_cli
{
    class Arguments
    {
        private string _username;
        private string _password;
        private string _mode;

        private string _captcha_file = "";
        private string _output_file = "";
        private string _ref_id = "";
        private string _page_url = "";
        private string _site_key = "";

        private string _captcha_id = "";

        private string _proxy = "";
        private string _token = "";

        private bool _case_sensitive = false;


        public string get_token()
        {
            return _token;
        }

        public void set_token(string token)
        {
            this._token = token;
        }

        public string get_username()
        {
            return _username;
        }

        public void set_username(string _username)
        {
            this._username = _username;
        }

        public string get_password()
        {
            return _password;
        }

        public void set_password(string _password)
        {
            this._password = _password;
        }

        public string get_mode()
        {
            return _mode;
        }

        public void set_mode(string _mode)
        {
            this._mode = _mode;
        }

        public string get_captcha_file()
        {
            return _captcha_file;
        }

        public void set_captcha_file(string _captcha_file)
        {
            this._captcha_file = _captcha_file;
        }

        public string get_output_file()
        {
            return _output_file;
        }

        public void set_output_file(string _output_file)
        {
            this._output_file = _output_file;
        }

        public string get_ref_id()
        {
            return _ref_id;
        }

        public void set_ref_id(string _ref_id)
        {
            this._ref_id = _ref_id;
        }

        public string get_page_url()
        {
            return _page_url;
        }

        public void set_page_url(string _page_url)
        {
            this._page_url = _page_url;
        }

        public string get_site_key()
        {
            return _site_key;
        }

        public void set_site_key(string _site_key)
        {
            this._site_key = _site_key;
        }

        public string get_captcha_id()
        {
            return _captcha_id;
        }

        public void set_captcha_id(string _captcha_id)
        {
            this._captcha_id = _captcha_id;
        }

        public bool is_case_sensitive()
        {
            return _case_sensitive;
        }

        public void set_case_sensitive(bool _case_sensitive)
        {
            this._case_sensitive = _case_sensitive;
        }

        public string get_proxy()
        {
            return _proxy;
        }

        public void set_proxy(string _proxy)
        {
            this._proxy = _proxy;
        }
    }
}