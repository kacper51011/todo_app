import { LayoutButton } from "../shared/components/LayoutButton";
import { Logo } from "../shared/components/Logo";

export const LandingNavbar = () => {
  return (
    <nav className="flex justify-between w-2/3">
      <Logo showText={true} color={"main"} />
      <div>
        <LayoutButton content="Login"></LayoutButton>
        <LayoutButton content="Join us!"></LayoutButton>
      </div>
    </nav>
  );
};
