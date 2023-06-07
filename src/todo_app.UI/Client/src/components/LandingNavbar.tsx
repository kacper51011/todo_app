import { LayoutButton } from "../shared/components/LayoutButton";
import { Logo } from "../shared/components/Logo";

export const LandingNavbar = () => {
  return (
    <nav className="flex justify-between max-md:w-full w-2/3 mb-10">
      <Logo showText={true} color="black" />
      <div role="menubar">
        <LayoutButton content="Login"></LayoutButton>
        <LayoutButton withColor content="Join us!"></LayoutButton>
      </div>
    </nav>
  );
};
