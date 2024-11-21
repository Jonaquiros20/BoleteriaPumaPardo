// Usar GSAP para animaciones
document.addEventListener("DOMContentLoaded", function () {
    gsap.from("h1", {
        duration: 1.2,
        y: -50,
        opacity: 0,
        ease: "power3.out"
    });

    gsap.from(".btn", {
        duration: 0.8,
        scale: 0,
        opacity: 0,
        stagger: 0.2,
        ease: "elastic.out(1, 0.5)"
    });
});
