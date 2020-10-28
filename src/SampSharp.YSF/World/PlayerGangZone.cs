using SampSharp.GameMode.Pools;
using SampSharp.GameMode.SAMP;
using SampSharp.GameMode.World;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampSharp.YSF.World
{
    public partial class PlayerGangZone : IdentifiedOwnedPool<PlayerGangZone, BasePlayer>
    {
        public PlayerGangZone(BasePlayer owner, float minX, float minY, float maxX, float maxY)
        {
            Owner = owner ?? throw new ArgumentNullException(nameof(owner));

            Id = PlayerGangZoneInternal.Instance.CreatePlayerGangZone(owner.Id, minX, minY, maxX, maxY);

            MinX = minX;
            MaxX = maxX;
            MinY = minY;
            MaxY = maxY;
        }

        /// <summary>
        ///     Gets the minimum x value for this <see cref="PlayerGangZone" />.
        /// </summary>
        public virtual float MinX { get; }

        /// <summary>
        ///     Gets the minimum y value for this <see cref="PlayerGangZone" />.
        /// </summary>
        public virtual float MinY { get; }

        /// <summary>
        ///     Gets the maximum x value for this <see cref="PlayerGangZone" />.
        /// </summary>
        public virtual float MaxX { get; }

        /// <summary>
        ///     Gets the maximum y value for this <see cref="PlayerGangZone" />.
        /// </summary>
        public virtual float MaxY { get; }

        public virtual Color Color => PlayerGangZoneInternal.Instance.PlayerGangZoneGetColor(Owner.Id, Id);
        public virtual Color FlashColor => PlayerGangZoneInternal.Instance.PlayerGangZoneGetFlashColor(Owner.Id, Id);

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (Id == -1) return;

            PlayerGangZoneInternal.Instance.PlayerGangZoneDestroy(Owner.Id, Id);
        }

        /// <summary>
        ///     Shows this <see cref="PlayerGangZone" />.
        /// </summary>
        public virtual void Show()
        {
            AssertNotDisposed();

            PlayerGangZoneInternal.Instance.PlayerGangZoneShow(Owner.Id, Id, Color);
        }

        /// <summary>
        ///     Hides this <see cref="PlayerGangZone" />.
        /// </summary>
        public virtual void Hide()
        {
            AssertNotDisposed();

            PlayerGangZoneInternal.Instance.PlayerGangZoneHide(Owner.Id, Id);
        }

        public virtual void Flash(Color color)
        {
            if (Owner == null) throw new ArgumentNullException(nameof(Owner));
            AssertNotDisposed();

            PlayerGangZoneInternal.Instance.PlayerGangZoneFlash(Owner.Id, Id, color);
        }

        /// <summary>
        ///     Stops this <see cref="PlayerGangZone" /> from flash.
        /// </summary>
        public virtual void StopFlash()
        {
            AssertNotDisposed();

            PlayerGangZoneInternal.Instance.PlayerGangZoneStopFlash(Owner.Id, Id);
        }
    }
}
