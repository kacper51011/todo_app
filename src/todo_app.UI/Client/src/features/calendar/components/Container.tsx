import { ComponentProps, PropsWithChildren } from "react";

type Props = PropsWithChildren & ComponentProps<"main">;

export const Container = ({ children, ...props }: Props) => {
  return (
    <main {...props} className=" bg-darkBackground py-2 px-10 w-full">
      {children}
    </main>
  );
};
