window.toggleTheme = function () {
    const light = document.getElementById('theme-light');
    const dark = document.getElementById('theme-dark');

    console.log("Light Theme:", light);
    console.log("Dark Theme:", dark);

    // Check if elements are found
    if (light && dark) {
        const isDark = !dark.disabled;

        if (isDark) {
            console.log("Switching to Light Theme");
            dark.disabled = true;
            light.disabled = false;
            localStorage.setItem('theme', 'light');
        } else {
            console.log("Switching to Dark Theme");
            dark.disabled = false;
            light.disabled = true;
            localStorage.setItem('theme', 'dark');
        }
    } else {
        console.error("Unable to find theme elements");
    }
};

window.applySavedTheme = function () {
    const savedTheme = localStorage.getItem('theme') || 'light'; // Default to light
    console.log("Applying Saved Theme:", savedTheme);

    if (savedTheme === 'dark') {
        document.getElementById('theme-dark').disabled = false;
        document.getElementById('theme-light').disabled = true;
    }
