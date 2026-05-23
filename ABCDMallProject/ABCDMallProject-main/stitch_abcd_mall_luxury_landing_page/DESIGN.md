---
name: ABCD Mall Premium
colors:
  surface: '#fbf9f8'
  surface-dim: '#dcd9d9'
  surface-bright: '#fbf9f8'
  surface-container-lowest: '#ffffff'
  surface-container-low: '#f6f3f2'
  surface-container: '#f0eded'
  surface-container-high: '#eae8e7'
  surface-container-highest: '#e4e2e1'
  on-surface: '#1b1c1c'
  on-surface-variant: '#464555'
  inverse-surface: '#303030'
  inverse-on-surface: '#f3f0f0'
  outline: '#777587'
  outline-variant: '#c7c4d8'
  surface-tint: '#4f44e2'
  primary: '#4d41df'
  on-primary: '#ffffff'
  primary-container: '#675df9'
  on-primary-container: '#fffbff'
  inverse-primary: '#c4c0ff'
  secondary: '#b0284b'
  on-secondary: '#ffffff'
  secondary-container: '#fd6483'
  on-secondary-container: '#670023'
  tertiary: '#585883'
  on-tertiary: '#ffffff'
  tertiary-container: '#71709d'
  on-tertiary-container: '#fffbff'
  error: '#ba1a1a'
  on-error: '#ffffff'
  error-container: '#ffdad6'
  on-error-container: '#93000a'
  primary-fixed: '#e3dfff'
  primary-fixed-dim: '#c4c0ff'
  on-primary-fixed: '#100069'
  on-primary-fixed-variant: '#3622ca'
  secondary-fixed: '#ffd9dd'
  secondary-fixed-dim: '#ffb2bc'
  on-secondary-fixed: '#400012'
  on-secondary-fixed-variant: '#8f0935'
  tertiary-fixed: '#e2dfff'
  tertiary-fixed-dim: '#c3c2f3'
  on-tertiary-fixed: '#17173e'
  on-tertiary-fixed-variant: '#43436c'
  background: '#fbf9f8'
  on-background: '#1b1c1c'
  surface-variant: '#e4e2e1'
typography:
  display-lg:
    fontFamily: Plus Jakarta Sans
    fontSize: 48px
    fontWeight: '800'
    lineHeight: '1.1'
    letterSpacing: -0.02em
  display-lg-mobile:
    fontFamily: Plus Jakarta Sans
    fontSize: 36px
    fontWeight: '800'
    lineHeight: '1.2'
  headline-lg:
    fontFamily: Plus Jakarta Sans
    fontSize: 32px
    fontWeight: '700'
    lineHeight: '1.2'
  headline-md:
    fontFamily: Plus Jakarta Sans
    fontSize: 24px
    fontWeight: '600'
    lineHeight: '1.3'
  body-lg:
    fontFamily: Inter
    fontSize: 18px
    fontWeight: '400'
    lineHeight: '1.6'
  body-md:
    fontFamily: Inter
    fontSize: 16px
    fontWeight: '400'
    lineHeight: '1.5'
  label-sm:
    fontFamily: Inter
    fontSize: 12px
    fontWeight: '600'
    lineHeight: '1'
    letterSpacing: 0.05em
rounded:
  sm: 0.25rem
  DEFAULT: 0.5rem
  md: 0.75rem
  lg: 1rem
  xl: 1.5rem
  full: 9999px
spacing:
  max-width: 1280px
  gutter: 24px
  margin-mobile: 16px
  margin-desktop: 48px
  section-gap: 80px
  stack-sm: 8px
  stack-md: 16px
  stack-lg: 32px
---

## Brand & Style
The design system for this luxury e-commerce platform evokes the vibrant, high-energy sophistication of Mumbai’s elite retail scene. The brand personality is **exuberant yet refined**, blending modern digital aesthetics with high-fashion sensibilities.

The visual style is a fusion of **Modern Corporate** and **Glassmorphism**. It utilizes clean lines and generous whitespace to signify luxury, while employing frosted glass textures and soft ambient glows to create a sense of depth and "digital craft." Every interaction should feel smooth and intentional, mirroring the white-glove service of a physical luxury mall.

- **Minimalism:** Use high-quality photography as the primary driver of the visual experience.
- **Glassmorphism:** Apply to navigation bars, filter overlays, and quick-view modals to maintain context and add a premium "sheen."
- **High-Contrast:** Use the deep navy and vibrant accent colors to guide the eye toward conversion points.

## Colors
The palette is designed to be striking and high-fashion. 

- **Primary (#6C63FF):** An electric purple used for primary calls to action, active states, and brand highlights.
- **Secondary (#FF6584):** A vibrant pink used for promotional accents, heart/wishlist icons, and seasonal highlights.
- **Dark/Tertiary (#2C2C54):** A deep, midnight navy used for high-level navigation, footers, and heavy structural elements to ground the design.
- **Background (#F8F9FA):** A cool, nearly-white gray that provides a clean canvas for glass effects.
- **Text (#333333):** A soft black for high readability without the harshness of pure black.

## Typography
The typography strategy pairs the geometric friendliness of **Plus Jakarta Sans** (serving as a modern alternative to Poppins with better screen rendering) for headlines with the functional precision of **Inter** for body text.

- **Headlines:** Use Bold (700) or ExtraBold (800) for hero sections. Headlines should have tight letter-spacing to feel impactful.
- **Body:** Inter is set with a generous line height (1.5 - 1.6) to ensure long product descriptions remain legible and inviting.
- **Labels:** Small labels, such as product categories or "New Arrival" tags, use uppercase with increased tracking for a sophisticated, editorial feel.

## Layout & Spacing
The layout follows a **Fixed Grid** philosophy for desktop, centering the content within a 1280px container to maintain a premium, controlled look on ultra-wide monitors.

- **Desktop (1280px+):** 12-column grid, 24px gutters, 48px side margins. Large section gaps (80px+) create the "luxury" of space.
- **Tablet (768px - 1024px):** 8-column grid, 24px gutters, 32px side margins.
- **Mobile (<768px):** 4-column grid, 16px gutters, 16px side margins.

Content should flow vertically with plenty of "breathable" air between product categories. Use asymmetrical layouts for editorial lookbooks to differentiate them from standard product grids.

## Elevation & Depth
Depth is achieved through **Tonal Layering** and **Glassmorphism** rather than traditional heavy shadows.

- **Level 0 (Background):** #F8F9FA.
- **Level 1 (Cards/Content):** Pure white with a very soft, 20px blur shadow at 4% opacity of the Primary color.
- **Level 2 (Overlays/Nav):** Semi-transparent white (70-80% opacity) with a 12px `backdrop-filter: blur()`. These surfaces should have a 1px white border at 20% opacity to simulate a glass edge.
- **Transitions:** Use 300ms "ease-out" curves for all hover states and modal entrances to maintain a smooth, liquid feel.

## Shapes
The design system uses a **Rounded** shape language to appear modern and approachable. 

- **Components:** Standard buttons and input fields use a 0.5rem (8px) radius.
- **Large Elements:** Product cards and hero banners use a 1rem (16px) or 1.5rem (24px) radius to soften the high-contrast imagery.
- **Interactive Icons:** Small utility buttons (like "add to cart" circles) should be fully pill-shaped.

## Components
- **Buttons:** Primary buttons are solid #6C63FF with white text. Hover states should involve a subtle scale-up (1.02x) and a shift to a slightly darker shade. Secondary buttons use a glass effect with a primary-colored border.
- **Product Cards:** Minimalist design with no visible borders. Use a soft shadow on hover. The product name uses `headline-md` and the price uses `body-lg` in a semi-bold weight.
- **Input Fields:** Use #FFFFFF with a subtle 1px border (#E0E0E0). On focus, the border shifts to #6C63FF with a soft outer glow.
- **Chips/Badges:** Small, pill-shaped tags for "Limited Edition" or "Mumbai Exclusive." Use #FF6584 for high-urgency tags.
- **Navigation:** The top header must be a glassmorphic bar that sticks to the top of the viewport, ensuring the deep navy (#2C2C54) of the logo/icons remains visible against diverse backgrounds.
- **Imagery:** All product photos should have a consistent "studio" lighting style with soft shadows, ideally on neutral or high-fashion editorial backgrounds.