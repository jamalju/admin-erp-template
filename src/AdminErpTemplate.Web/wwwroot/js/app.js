/**
 * AdminERP Application Scripts
 * General utilities and page-specific initializations
 */
(function () {
    'use strict';

    // Initialize Bootstrap tooltips
    var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'));
    tooltipTriggerList.forEach(function (el) {
        new bootstrap.Tooltip(el);
    });

    // Initialize Bootstrap popovers
    var popoverTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="popover"]'));
    popoverTriggerList.forEach(function (el) {
        new bootstrap.Popover(el);
    });

    // Keyboard shortcuts
    document.addEventListener('keydown', function (e) {
        // Ctrl+K: Focus search
        if ((e.ctrlKey || e.metaKey) && e.key === 'k') {
            e.preventDefault();
            var search = document.querySelector('.search-input');
            if (search) search.focus();
        }

        // Escape: Close sidebar on mobile
        if (e.key === 'Escape') {
            var sidebar = document.getElementById('erpSidebar');
            var overlay = document.getElementById('sidebarOverlay');
            if (sidebar && sidebar.classList.contains('show')) {
                sidebar.classList.remove('show');
                overlay.classList.remove('active');
                document.body.style.overflow = '';
            }
        }
    });

    // Auto-dismiss alerts after 5 seconds
    document.querySelectorAll('.alert-dismissible.auto-dismiss').forEach(function (alert) {
        setTimeout(function () {
            var bsAlert = bootstrap.Alert.getOrCreateInstance(alert);
            bsAlert.close();
        }, 5000);
    });

    // Smooth scroll to top
    window.scrollToTop = function () {
        window.scrollTo({ top: 0, behavior: 'smooth' });
    };
})();
