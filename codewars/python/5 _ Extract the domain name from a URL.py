#Write a function that when given a URL as a string, parses out just the domain name and returns it as a string. For example:
#domain_name("http://github.com/carbonfive/raygun") == "github" 
#domain_name("http://www.zombie-bites.com") == "zombie-bites"
#domain_name("github.com") == "github"
def domain_name(url):
    return (lambda url=url.split("//")[1].split(".") if "//" in url else url.split(".") : url[1] if url[0] == "www" else url[0])()
