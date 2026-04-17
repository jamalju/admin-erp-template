/**
 * AdminERP Sidebar Manager
 * Handles sidebar toggle, collapse, mobile behavior, and layout switching
 */
(function () {
    'use strict';

    const LAYOUT_KEY = 'erp-menu-layout';
    const COLLAPSED_KEY = 'erp-sidebar-collapsed';
    const body = document.getElementById('erp-body');
    const sidebar = document.getElementById('erpSidebar');
    const sidebarToggle = document.getElementById('sidebarToggle');
    const sidebarClose = document.getElementById('sidebarClose');
    const sidebarOverlay = document.getElementById('sidebarOverlay');
    const menuLayoutToggle = document.getElementById('menuLayoutToggle');
    const menuLayoutIcon = document.getElementById('menuLayoutIcon');
    const horizontalMenu = document.getElementById('erpHorizontalMenu');

    function isMobile() {
        return window.innerWidth < 992;
    }

    function getStoredLayout() {
        return localStorage.getItem(LAYOUT_KEY) || 'sidebar';
    }

    function isCollapsed() {
        return localStorage.getItem(COLLAPSED_KEY) === 'true';
    }

    // Initialize layout
    function initLayout() {
        var layout = getStoredLayout();
        setLayout(layout);

        if (!isMobile() && isCollapsed()) {
            body.classList.add('sidebar-collapsed');
        }
    }

    function setLayout(layout) {
        localStorage.setItem(LAYOUT_KEY, layout);

        if (layout === 'horizontal') {
            body.classList.add('layout-horizontal');
            if (menuLayoutIcon) {
                menuLayoutIcon.className = 'bi bi-layout-sidebar';
            }
        } else {
            body.classList.remove('layout-horizontal');
            if (menuLayoutIcon) {
                menuLayoutIcon.className = 'bi bi-layout-text-sidebar-reverse';
            }
        }
    }

    // Sidebar toggle (collapse on desktop, show/hide on mobile)
    if (sidebarToggle) {
        sidebarToggle.addEventListener('click', function () {
            if (isMobile()) {
                sidebar.classList.toggle('show');
                sidebarOverlay.classList.toggle('active');
                document.body.style.overflow = sidebar.classList.contains('show') ? 'hidden' : '';
            } else {
                body.classList.toggle('sidebar-collapsed');
                localStorage.setItem(COLLAPSED_KEY, body.classList.contains('sidebar-collapsed'));
            }
        });
    }

    // Close sidebar on mobile
    if (sidebarClose) {
        sidebarClose.addEventListener('click', function () {
            sidebar.classList.remove('show');
            sidebarOverlay.classList.remove('active');
            document.body.style.overflow = '';
        });
    }

    // Close sidebar when overlay clicked
    if (sidebarOverlay) {
        sidebarOverlay.addEventListener('click', function () {
            sidebar.classList.remove('show');
            sidebarOverlay.classList.remove('active');
            document.body.style.overflow = '';
        });
    }

    // Menu layout toggle (sidebar <-> horizontal)
    if (menuLayoutToggle) {
        menuLayoutToggle.addEventListener('click', function () {
            var current = getStoredLayout();
            setLayout(current === 'sidebar' ? 'horizontal' : 'sidebar');
        });
    }

    // Handle window resize
    var resizeTimer;
    window.addEventListener('resize', function () {
        clearTimeout(resizeTimer);
        resizeTimer = setTimeout(function () {
            if (!isMobile()) {
                sidebar.classList.remove('show');
                sidebarOverlay.classList.remove('active');
                document.body.style.overflow = '';
            }
        }, 250);
    });

    // Highlight active menu item
    function highlightActiveMenu() {
        var path = window.location.pathname.toLowerCase();
        document.querySelectorAll('.sidebar-link, .sidebar-sublink').forEach(function (link) {
            var href = (link.getAttribute('href') || '').toLowerCase();
            if (href && href !== '#' && href !== 'javascript:void(0)') {
                if (path === href || path.startsWith(href + '/')) {
                    link.classList.add('active');
                    // Expand parent menus
                    var parent = link.closest('.submenu-collapse');
                    while (parent) {
                        parent.classList.add('show');
                        var toggle = parent.previousElementSibling;
                        if (toggle) {
                            toggle.setAttribute('aria-expanded', 'true');
                        }
                        parent = parent.parentElement.closest('.submenu-collapse');
                    }
                }
            }
        });
    }

    // Initialize
    initLayout();
    highlightActiveMenu();
})();
