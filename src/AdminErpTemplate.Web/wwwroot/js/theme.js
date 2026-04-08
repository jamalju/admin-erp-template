/**
 * AdminERP Theme Manager
 * Handles dark/light mode toggle and color scheme switching
 */
(function () {
    'use strict';

    const THEME_KEY = 'erp-theme-mode';
    const SCHEME_KEY = 'erp-color-scheme';
    const html = document.documentElement;
    const themeToggle = document.getElementById('themeToggle');
    const themeIcon = document.getElementById('themeIcon');

    function getStoredTheme() {
        return localStorage.getItem(THEME_KEY) || 'light';
    }

    function getStoredScheme() {
        return localStorage.getItem(SCHEME_KEY) || 'default';
    }

    function setTheme(mode) {
        html.setAttribute('data-bs-theme', mode);
        localStorage.setItem(THEME_KEY, mode);
        updateThemeIcon(mode);
    }

    function updateThemeIcon(mode) {
        if (themeIcon) {
            themeIcon.className = mode === 'dark' ? 'bi bi-sun' : 'bi bi-moon-stars';
        }
    }

    function setColorScheme(scheme) {
        html.setAttribute('data-color-scheme', scheme);
        localStorage.setItem(SCHEME_KEY, scheme);
        updateActiveScheme(scheme);
    }

    function updateActiveScheme(scheme) {
        document.querySelectorAll('.color-swatch').forEach(function (swatch) {
            swatch.classList.toggle('active', swatch.dataset.scheme === scheme);
        });
    }

    // Initialize theme
    setTheme(getStoredTheme());
    setColorScheme(getStoredScheme());

    // Theme toggle button
    if (themeToggle) {
        themeToggle.addEventListener('click', function () {
            var current = html.getAttribute('data-bs-theme');
            setTheme(current === 'dark' ? 'light' : 'dark');
        });
    }

    // Color scheme swatches
    document.querySelectorAll('.color-swatch').forEach(function (swatch) {
        swatch.addEventListener('click', function (e) {
            e.preventDefault();
            e.stopPropagation();
            setColorScheme(this.dataset.scheme);
        });
    });

    // Fullscreen toggle
    var fullscreenBtn = document.getElementById('fullscreenToggle');
    if (fullscreenBtn) {
        fullscreenBtn.addEventListener('click', function () {
            if (!document.fullscreenElement) {
                document.documentElement.requestFullscreen();
            } else {
                document.exitFullscreen();
            }
        });
    }
})();
