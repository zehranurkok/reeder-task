function setTheme(themeName) {
    
    localStorage.setItem('theme', themeName);
    document.documentElement.className = themeName;
}

function randomTheme() {
    switch (x > 0) {
    case 1: {
        setTheme('bg-red');
    }
    case 2: {
        setTheme('bg-blue');
    }
    case 3: {
        setTheme('bg-green');
    }}
}